-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto_izuwu
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `diagnostico`
--

DROP TABLE IF EXISTS `diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnostico` (
  `ID_Diag` varchar(11) NOT NULL,
  `Contenido` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Diag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico`
--

LOCK TABLES `diagnostico` WRITE;
/*!40000 ALTER TABLE `diagnostico` DISABLE KEYS */;
INSERT INTO `diagnostico` VALUES ('DAP-AAA-001','Gripe'),('DAP-AAA-002','Covid');
/*!40000 ALTER TABLE `diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostico_app`
--

DROP TABLE IF EXISTS `diagnostico_app`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnostico_app` (
  `ID_DAPP` varchar(11) NOT NULL,
  `ID_PAC` varchar(11) NOT NULL,
  `FechaHora` date NOT NULL,
  PRIMARY KEY (`ID_DAPP`),
  KEY `ID_PAC` (`ID_PAC`),
  CONSTRAINT `diagnostico_app_ibfk_1` FOREIGN KEY (`ID_DAPP`) REFERENCES `diagnostico` (`ID_Diag`),
  CONSTRAINT `diagnostico_app_ibfk_2` FOREIGN KEY (`ID_PAC`) REFERENCES `paciente` (`ID_PAC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico_app`
--

LOCK TABLES `diagnostico_app` WRITE;
/*!40000 ALTER TABLE `diagnostico_app` DISABLE KEYS */;
INSERT INTO `diagnostico_app` VALUES ('DAP-AAA-001','PAC-AAA-001','2020-08-18'),('DAP-AAA-002','PAC-AAA-004','2020-05-14');
/*!40000 ALTER TABLE `diagnostico_app` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostico_med`
--

DROP TABLE IF EXISTS `diagnostico_med`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnostico_med` (
  `ID_DMED` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_DMED`),
  CONSTRAINT `diagnostico_med_ibfk_1` FOREIGN KEY (`ID_DMED`) REFERENCES `diagnostico` (`ID_Diag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico_med`
--

LOCK TABLES `diagnostico_med` WRITE;
/*!40000 ALTER TABLE `diagnostico_med` DISABLE KEYS */;
/*!40000 ALTER TABLE `diagnostico_med` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genera`
--

DROP TABLE IF EXISTS `genera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genera` (
  `ID_MED` varchar(11) NOT NULL,
  `ID_DMED` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_DMED`),
  KEY `ID_MED` (`ID_MED`),
  CONSTRAINT `genera_ibfk_1` FOREIGN KEY (`ID_MED`) REFERENCES `usuario` (`ID_US`),
  CONSTRAINT `genera_ibfk_2` FOREIGN KEY (`ID_DMED`) REFERENCES `diagnostico` (`ID_Diag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genera`
--

LOCK TABLES `genera` WRITE;
/*!40000 ALTER TABLE `genera` DISABLE KEYS */;
/*!40000 ALTER TABLE `genera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestor`
--

DROP TABLE IF EXISTS `gestor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gestor` (
  `ID_GES` varchar(11) NOT NULL,
  `Empresa` varchar(60) NOT NULL,
  PRIMARY KEY (`ID_GES`),
  CONSTRAINT `gestor_ibfk_1` FOREIGN KEY (`ID_GES`) REFERENCES `usuario` (`ID_US`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestor`
--

LOCK TABLES `gestor` WRITE;
/*!40000 ALTER TABLE `gestor` DISABLE KEYS */;
/*!40000 ALTER TABLE `gestor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico` (
  `Espacializacion` varchar(30) DEFAULT NULL,
  `ID_MED` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_MED`),
  CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`ID_MED`) REFERENCES `usuario` (`ID_US`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
INSERT INTO `medico` VALUES ('Pediatra','MED-AAA-003');
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `ID_PAC` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_PAC`),
  CONSTRAINT `paciente_ibfk_1` FOREIGN KEY (`ID_PAC`) REFERENCES `usuario` (`ID_US`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES ('PAC-AAA-001'),('PAC-AAA-002'),('PAC-AAA-004');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patologia`
--

DROP TABLE IF EXISTS `patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patologia` (
  `Nombre` varchar(90) NOT NULL,
  `Prioridad` char(1) NOT NULL,
  `ID_PAT` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_PAT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patologia`
--

LOCK TABLES `patologia` WRITE;
/*!40000 ALTER TABLE `patologia` DISABLE KEYS */;
INSERT INTO `patologia` VALUES ('Covid','5','CVD-AAA-001'),('Gripe','3','GRP-AAA-002');
/*!40000 ALTER TABLE `patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posee`
--

DROP TABLE IF EXISTS `posee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posee` (
  `Fecha` date NOT NULL,
  `ID_SIN` varchar(11) NOT NULL,
  `ID_PAC` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_SIN`,`ID_PAC`),
  KEY `ID_PAC` (`ID_PAC`),
  CONSTRAINT `posee_ibfk_1` FOREIGN KEY (`ID_PAC`) REFERENCES `paciente` (`ID_PAC`),
  CONSTRAINT `posee_ibfk_2` FOREIGN KEY (`ID_SIN`) REFERENCES `sintoma` (`ID_SIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posee`
--

LOCK TABLES `posee` WRITE;
/*!40000 ALTER TABLE `posee` DISABLE KEYS */;
INSERT INTO `posee` VALUES ('2020-07-23','FSC-AAA-004','PAC-AAA-002'),('2020-07-13','FSC-AAA-006','PAC-AAA-001'),('2020-07-18','FSC-AAA-009','PAC-AAA-004');
/*!40000 ALTER TABLE `posee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resulta`
--

DROP TABLE IF EXISTS `resulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `resulta` (
  `ID_Diag` varchar(11) NOT NULL,
  `ID_PAT` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_Diag`,`ID_PAT`),
  KEY `ID_PAT` (`ID_PAT`),
  CONSTRAINT `resulta_ibfk_1` FOREIGN KEY (`ID_Diag`) REFERENCES `diagnostico` (`ID_Diag`),
  CONSTRAINT `resulta_ibfk_2` FOREIGN KEY (`ID_PAT`) REFERENCES `patologia` (`ID_PAT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resulta`
--

LOCK TABLES `resulta` WRITE;
/*!40000 ALTER TABLE `resulta` DISABLE KEYS */;
INSERT INTO `resulta` VALUES ('DAP-AAA-002','CVD-AAA-001'),('DAP-AAA-001','GRP-AAA-002');
/*!40000 ALTER TABLE `resulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sintoma` (
  `Nombre` varchar(90) NOT NULL,
  `ID_SIN` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_SIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintoma`
--

LOCK TABLES `sintoma` WRITE;
/*!40000 ALTER TABLE `sintoma` DISABLE KEYS */;
INSERT INTO `sintoma` VALUES ('Tos seca','FSC-AAA-002'),('Tos','FSC-AAA-003'),('Fiebre','FSC-AAA-004'),('Mocos','FSC-AAA-006'),('Dificultad respi','FSC-AAA-009'),('Mareos','FSC-AAA-010');
/*!40000 ALTER TABLE `sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono_us`
--

DROP TABLE IF EXISTS `telefono_us`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefono_us` (
  `Telefono` char(11) NOT NULL,
  `ID_US` varchar(11) NOT NULL,
  PRIMARY KEY (`Telefono`,`ID_US`),
  KEY `ID_US` (`ID_US`),
  CONSTRAINT `telefono_us_ibfk_1` FOREIGN KEY (`ID_US`) REFERENCES `usuario` (`ID_US`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono_us`
--

LOCK TABLES `telefono_us` WRITE;
/*!40000 ALTER TABLE `telefono_us` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono_us` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiene` (
  `ID_PAT` varchar(11) NOT NULL,
  `ID_SIN` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_PAT`,`ID_SIN`),
  KEY `ID_SIN` (`ID_SIN`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`ID_PAT`) REFERENCES `patologia` (`ID_PAT`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`ID_SIN`) REFERENCES `sintoma` (`ID_SIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
INSERT INTO `tiene` VALUES ('CVD-AAA-001','FSC-AAA-002'),('GRP-AAA-002','FSC-AAA-003'),('GRP-AAA-002','FSC-AAA-004'),('GRP-AAA-002','FSC-AAA-006'),('CVD-AAA-001','FSC-AAA-009');
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_trt`
--

DROP TABLE IF EXISTS `tipo_trt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_trt` (
  `Tipo` varchar(15) NOT NULL,
  `ID_TRT` varchar(11) NOT NULL,
  PRIMARY KEY (`ID_TRT`),
  CONSTRAINT `tipo_trt_ibfk_1` FOREIGN KEY (`ID_TRT`) REFERENCES `tratamiento` (`ID_TRT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_trt`
--

LOCK TABLES `tipo_trt` WRITE;
/*!40000 ALTER TABLE `tipo_trt` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_trt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tratamiento`
--

DROP TABLE IF EXISTS `tratamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tratamiento` (
  `ID_TRT` varchar(11) NOT NULL,
  `Cantidad` varchar(10) NOT NULL,
  `Descripcion` varchar(90) NOT NULL,
  `Tipo` varchar(15) NOT NULL,
  PRIMARY KEY (`ID_TRT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tratamiento`
--

LOCK TABLES `tratamiento` WRITE;
/*!40000 ALTER TABLE `tratamiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tratamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Email` varchar(90) NOT NULL,
  `ID_US` varchar(11) NOT NULL,
  `Direccion` varchar(30) NOT NULL,
  `CI` char(9) NOT NULL,
  `Contraseña` varchar(90) NOT NULL,
  `Telefono` char(11) NOT NULL,
  `FDN` date NOT NULL,
  PRIMARY KEY (`ID_US`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('Nicolas','Pere','nicoperemedico@gmail.com','MED-AAA-003','la casa de la salud','50921456','soymedico123','53895277648','1996-09-01'),('Bruno','Pintos','pintosbruno@gmail.com','PAC-AAA-001','Bruselas esq londres','56505181','dsadsdsasdase','53892734366','2002-07-18'),('Cristian','norte','norte@gmail,com','PAC-AAA-002','la casas de norte','46503171','dsadsdsadsasdasdsdase','53892734266','2003-01-22'),('Ignacio','Franco','nachofranco@gmail.com','PAC-AAA-004','Jose jupes','56785189','eltachitoga','53891524823','2002-10-30');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-18 23:10:50
