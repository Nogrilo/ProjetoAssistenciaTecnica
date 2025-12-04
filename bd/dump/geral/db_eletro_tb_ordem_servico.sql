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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:26:21
