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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:26:21
