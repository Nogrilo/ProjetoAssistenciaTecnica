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
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` VALUES (26,21),(27,42),(28,44),(29,46),(30,48),(31,49),(32,50),(33,52),(34,53),(35,55);
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_concerto`
--

LOCK TABLES `tb_concerto` WRITE;
/*!40000 ALTER TABLE `tb_concerto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_concerto` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_concerto_pecas`
--

LOCK TABLES `tb_concerto_pecas` WRITE;
/*!40000 ALTER TABLE `tb_concerto_pecas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_concerto_pecas` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_endereco`
--

LOCK TABLES `tb_endereco` WRITE;
/*!40000 ALTER TABLE `tb_endereco` DISABLE KEYS */;
INSERT INTO `tb_endereco` VALUES (4,'SC','Canoinhas','89462-486','Avenida Senador Ivo D\'Áquino','Industrial 1','Casa','69',46),(5,'SC','Canoinhas','89462-486','Avenida Senador Ivo D\'Áquino','Industrial 1','Casa','69',48),(6,'SC','Canoinhas','89464-024','Rua Wilibaldo Arnoldo Hoffmann','Jardim Esperança','Casa','21',49),(7,'SC','Canoinhas','89464-024','Rua Wilibaldo Arnoldo Hoffmann','Jardim Esperança','Casa','21',52),(8,'SC','Canoinhas','89464-024','Rua Wilibaldo Arnoldo Hoffmann','Jardim Esperança','Casa','21',53),(9,'SC','Canoinhas','89464-024','Rua Wilibaldo Arnoldo Hoffmann','Jardim Esperança','Casa','21',55);
/*!40000 ALTER TABLE `tb_endereco` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_estoque_pecas`
--

LOCK TABLES `tb_estoque_pecas` WRITE;
/*!40000 ALTER TABLE `tb_estoque_pecas` DISABLE KEYS */;
INSERT INTO `tb_estoque_pecas` VALUES (1,'grande',10.00,15.00,'123'),(2,'grande',10.00,15.00,'PC10203019'),(3,'grande',10.00,15.00,'PC10203030'),(4,'vitorbunda',10.00,15.00,'PC10203048'),(5,'Fusivel',31.00,1.00,'PC12205'),(6,'Fusivel grosso',31.00,21.00,'PC122535');
/*!40000 ALTER TABLE `tb_estoque_pecas` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_funcionario`
--

LOCK TABLES `tb_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcionario` VALUES (1,48,1,'2025-10-24','Auxiliar Técnico','48',30);
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_orcamento`
--

LOCK TABLES `tb_orcamento` WRITE;
/*!40000 ALTER TABLE `tb_orcamento` DISABLE KEYS */;
INSERT INTO `tb_orcamento` VALUES (1,70.00);
/*!40000 ALTER TABLE `tb_orcamento` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_ordem_servico`
--

LOCK TABLES `tb_ordem_servico` WRITE;
/*!40000 ALTER TABLE `tb_ordem_servico` DISABLE KEYS */;
INSERT INTO `tb_ordem_servico` VALUES (2,1,1,'tem que ver','2025-11-18','nao tem','Na fila para concerto',1,44,4),(3,1,2,'tem que ver','2025-11-18','nao tem','Na fila para concerto',1,44,4),(4,2,1,'ksdfds','2025-11-18','nao tem','Na fila para concerto',1,44,5),(5,2,2,'ksdfds','2025-11-18','nao tem','Na fila para concerto',1,44,5),(6,2,3,'ksdfds','2025-11-18','nao tem','Na fila para concerto',1,44,5),(7,2,4,'ksdfds','2025-11-18','nao tem','Na fila para concerto',1,48,5),(8,3,1,'quebrado','2025-11-26','vibrador','Na fila para concerto',1,42,11),(9,4,1,'Nao me da prazer','2025-11-27','Camisinha','Na fila para concerto',1,46,10),(10,4,2,'Nao me da prazer','2025-11-27','lubrificante','Na fila para concerto',1,46,10);
/*!40000 ALTER TABLE `tb_ordem_servico` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `tb_pessoa`
--

LOCK TABLES `tb_pessoa` WRITE;
/*!40000 ALTER TABLE `tb_pessoa` DISABLE KEYS */;
INSERT INTO `tb_pessoa` VALUES (21,'','','','','0001-01-01','2025-10-23'),(42,'Vinicius PIPIS','11392688990','(32) 9 3218-3291','vinicius','2003-10-17','2025-10-24'),(44,'Filipe O fodao games','12191358950','(47) 9 8444-1721','filipe@gmail.com','2005-09-02','2025-10-24'),(46,'Filipe O fodao games','12191358969','(47) 9 8444-1721','filipe@gmail.com','2005-09-02','2025-10-24'),(48,'Filipe O fodao games','12191358931','(47) 9 8444-1721','filipe@gmail.com','2005-09-02','2025-10-24'),(49,'Vinicius','149.145.510-12','(47) 9 9232-7068','vinicius@gmail.com','2000-01-25','2025-11-15'),(50,'Ana Nogath','36706247081','(32) 1 9831-2983','ana@gmail.com','2006-06-29','2025-12-01'),(52,'Ana Nogath','83588020055','(32) 1 9831-2983','ana@gmail.com','2006-06-29','2025-12-01'),(53,'Ana pipi','22854324021','(32) 1 3213-2131','ana@paula@pipis','2006-06-29','2025-12-01'),(55,'Ana popos','68594364091','(32) 1 9323-2131','32132321','2006-06-29','2025-12-01');
/*!40000 ALTER TABLE `tb_pessoa` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Dumping data for table `tb_produto`
--

LOCK TABLES `tb_produto` WRITE;
/*!40000 ALTER TABLE `tb_produto` DISABLE KEYS */;
INSERT INTO `tb_produto` VALUES (4,44,'Cadence','jiodas87934','8859827985','Batedeira Orbital',NULL),(5,44,'Cuzinhogames','sss','8969','Massageador de prostatas',NULL),(6,44,'seloco','34','sssssdasf','Marcelo',NULL),(7,42,'Philco','Grande','20','Batedeira','Cadastro'),(8,42,'Philco','Grande','20','Liquidificador','Cadastro'),(9,42,'Philco','Grande','20','Vibrador','Cadastro'),(10,42,'Sex','Vibrador Gigante!','69','Gigante','Deliciosa'),(11,42,'Renault','Sedan','69','Carro','Bom, mas esgangando'),(12,42,'Mondial','Grande','29','Vibrador','1'),(13,42,'Sex','Grande','21','Pepino','Boa'),(14,42,'Philco','Legal','20','Liquidificador','Funcionando'),(15,42,'Philco','Legal','20','Liquidificador','Funcionando'),(16,42,'Pipi','dasdas','21','lksama','dada'),(17,21,'','','','',''),(18,42,'Sex','Dildo','6996','Grande','1');
/*!40000 ALTER TABLE `tb_produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:27:22
