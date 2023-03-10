-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: appdevproj
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `tbltotalqnty`
--

DROP TABLE IF EXISTS `tbltotalqnty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltotalqnty` (
  `itemcode` varchar(45) NOT NULL,
  `stockhldr` varchar(45) NOT NULL,
  `storageloc` varchar(45) NOT NULL,
  `totalqnty` int NOT NULL,
  PRIMARY KEY (`itemcode`,`stockhldr`,`storageloc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltotalqnty`
--

LOCK TABLES `tbltotalqnty` WRITE;
/*!40000 ALTER TABLE `tbltotalqnty` DISABLE KEYS */;
INSERT INTO `tbltotalqnty` VALUES ('100005','ABC Tech','ABC Tech',90),('100005','ABC Tech','XYZ Center',10),('100005','XYZ Inc','ABC Tech',200),('1200','ABC Tech','ABC Center',750),('1200','XYZ Inc.','ABC Center',250),('1200','XYZ Inc.','XYZ Center',500),('1201','ABC Tech','ABC Center',1600),('1201','ABC Tech','ABC Mini Storage',645),('1201','XYZ Inc','XYZ Center',650),('1210','ABC Tech','XYZ Center',10),('1210','XYZ Inc','XYZ Center',15),('1210','XYZ Inc','XYZ Mini Storage',350),('1218','ABC Tech','Adv Center',0),('1218','ABC Tech','XYZ Center',300),('1218','Adv Corp','Adv Center',350),('1218','XYZ Inc','Adv Center',880),('1227','Adv Corp','Adv Center',235),('1227','Adv Corp','XYZ Center',2450),('1245x','ABC Company `','Tech Inc.',0);
/*!40000 ALTER TABLE `tbltotalqnty` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-10 18:04:12
