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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-04 17:26:21
