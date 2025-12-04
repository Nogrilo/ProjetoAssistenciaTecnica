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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:26:20
