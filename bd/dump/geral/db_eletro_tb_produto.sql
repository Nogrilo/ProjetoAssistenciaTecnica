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

-- Dump completed on 2025-12-04 17:26:20
