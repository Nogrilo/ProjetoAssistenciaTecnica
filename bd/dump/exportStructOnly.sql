-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: db_eletro
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

create database db_eletro2;

use db_eletro2;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  PRIMARY KEY (`idCliente`),
  KEY `FK_CLIENTE_PESSOA` (`id_pessoa`),
  CONSTRAINT `FK_CLIENTE_PESSOA` FOREIGN KEY (`id_pessoa`) REFERENCES `tb_pessoa` (`idPessoa`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_concerto`
--

DROP TABLE IF EXISTS `tb_concerto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_concerto` (
  `idConcerto` int NOT NULL AUTO_INCREMENT,
  `id_ordem_servico` int NOT NULL,
  `id_tecnico` int NOT NULL,
  `comissao_tecnico` int DEFAULT '7',
  `adicional_pecas` decimal(6,2) DEFAULT '0.00',
  `adicional_frete` decimal(6,2) DEFAULT '0.00',
  `valor_adicional` decimal(6,2) DEFAULT '0.00',
  `desc_servico` text,
  `data_saida` date DEFAULT NULL,
  `validade_garantia` date DEFAULT NULL,
  PRIMARY KEY (`idConcerto`),
  KEY `FK_CONCERTO_ORDEM` (`id_ordem_servico`),
  KEY `IDX_TECNICO` (`id_tecnico`),
  CONSTRAINT `FK_CONCERTO_FUNCIONARIO` FOREIGN KEY (`id_tecnico`) REFERENCES `tb_funcionario` (`idFuncionario`) ON DELETE CASCADE,
  CONSTRAINT `FK_CONCERTO_ORDEM` FOREIGN KEY (`id_ordem_servico`) REFERENCES `tb_ordem_servico` (`idOrdem_servico`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_concerto_pecas`
--

DROP TABLE IF EXISTS `tb_concerto_pecas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_concerto_pecas` (
  `idConcerto_pecas` int NOT NULL AUTO_INCREMENT,
  `id_concerto` int NOT NULL,
  `id_peca` int NOT NULL,
  PRIMARY KEY (`idConcerto_pecas`),
  KEY `FK_TBCP_CONCERTO` (`id_concerto`),
  KEY `FK_TBCP_PECA` (`id_peca`),
  CONSTRAINT `FK_TBCP_CONCERTO` FOREIGN KEY (`id_concerto`) REFERENCES `tb_concerto` (`idConcerto`) ON DELETE CASCADE,
  CONSTRAINT `FK_TBCP_PECA` FOREIGN KEY (`id_peca`) REFERENCES `tb_estoque_pecas` (`idPeca`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_endereco`
--

DROP TABLE IF EXISTS `tb_endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_endereco` (
  `idEndereco` int NOT NULL AUTO_INCREMENT,
  `estado` char(2) NOT NULL,
  `municipio` varchar(125) NOT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `rua` varchar(255) NOT NULL,
  `bairro` varchar(255) NOT NULL,
  `complemento` varchar(100) NOT NULL,
  `n_complemento` varchar(25) NOT NULL,
  `id_pertencente` int NOT NULL,
  PRIMARY KEY (`idEndereco`),
  KEY `FK_ENDERECO_PESSOA` (`id_pertencente`),
  CONSTRAINT `FK_ENDERECO_PESSOA` FOREIGN KEY (`id_pertencente`) REFERENCES `tb_pessoa` (`idPessoa`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_estoque_pecas`
--

DROP TABLE IF EXISTS `tb_estoque_pecas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_estoque_pecas` (
  `idPeca` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL,
  `valor_custo` decimal(6,2) NOT NULL,
  `valor_repasse` decimal(6,2) NOT NULL,
  `codigo` varchar(10) NOT NULL,
  PRIMARY KEY (`idPeca`),
  UNIQUE KEY `codigo` (`codigo`),
  KEY `IDX_PECA` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionario` (
  `idFuncionario` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  `data_adimissao` date DEFAULT NULL,
  `tipo` enum('Auxiliar Técnico','Recepcionista','Gerente Técnico','Gerente Administrativo','Outro') NOT NULL,
  `codigo_funcionario` varchar(6) NOT NULL,
  `porcentagem_comissao` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`idFuncionario`),
  UNIQUE KEY `codigo_funcionario` (`codigo_funcionario`),
  KEY `FK_FUNCIONARIO_PESSOA` (`id_pessoa`),
  CONSTRAINT `FK_FUNCIONARIO_PESSOA` FOREIGN KEY (`id_pessoa`) REFERENCES `tb_pessoa` (`idPessoa`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_orcamento`
--

DROP TABLE IF EXISTS `tb_orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_orcamento` (
  `idOrcamento` int NOT NULL AUTO_INCREMENT,
  `valor` decimal(6,2) NOT NULL,
  PRIMARY KEY (`idOrcamento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_ordem_servico`
--

DROP TABLE IF EXISTS `tb_ordem_servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ordem_servico` (
  `idOrdem_servico` int NOT NULL AUTO_INCREMENT,
  `tick` int NOT NULL,
  `n_atendimento` int NOT NULL,
  `defeito` text NOT NULL,
  `data_abertura` date NOT NULL,
  `acessorios` varchar(155) NOT NULL DEFAULT 'Não possui',
  `status` enum('Na fila para concerto','Esperando peça','Esperando orçamento','Saída') NOT NULL,
  `id_orcamento_inicial` int NOT NULL,
  `id_pertencente` int NOT NULL,
  `id_produto` int NOT NULL,
  PRIMARY KEY (`idOrdem_servico`),
  KEY `FK_ORDEM_ORCAMENTO` (`id_orcamento_inicial`),
  KEY `FK_ORDEM_PESSOA` (`id_pertencente`),
  KEY `FK_ORDEM_PRODUTO` (`id_produto`),
  KEY `IDX_TICK` (`tick`),
  CONSTRAINT `FK_ORDEM_ORCAMENTO` FOREIGN KEY (`id_orcamento_inicial`) REFERENCES `tb_orcamento` (`idOrcamento`) ON DELETE CASCADE,
  CONSTRAINT `FK_ORDEM_PESSOA` FOREIGN KEY (`id_pertencente`) REFERENCES `tb_pessoa` (`idPessoa`) ON DELETE CASCADE,
  CONSTRAINT `FK_ORDEM_PRODUTO` FOREIGN KEY (`id_produto`) REFERENCES `tb_produto` (`idProduto`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_pessoa`
--

DROP TABLE IF EXISTS `tb_pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_pessoa` (
  `idPessoa` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(155) NOT NULL,
  `cpf_cnpj` varchar(20) NOT NULL,
  `telefone` varchar(16) NOT NULL,
  `email` varchar(100) NOT NULL,
  `data_nascimento` date NOT NULL,
  `data_cadastro` date DEFAULT NULL,
  PRIMARY KEY (`idPessoa`),
  UNIQUE KEY `cpf_cnpj` (`cpf_cnpj`),
  KEY `IDX_PESSOA` (`cpf_cnpj`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produto` (
  `idProduto` int NOT NULL AUTO_INCREMENT,
  `id_pertencente` bigint NOT NULL,
  `marca` varchar(50) DEFAULT NULL,
  `modelo` varchar(50) DEFAULT NULL,
  `n_serie` varchar(50) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `condicao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idProduto`),
  KEY `FK_PRODUTO_PESSOA` (`id_pertencente`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:32:57
