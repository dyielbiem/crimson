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
-- Table structure for table `tblentries`
--

DROP TABLE IF EXISTS `tblentries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblentries` (
  `itemcode` varchar(45) NOT NULL,
  `curstockhldr` varchar(45) NOT NULL,
  `curstorage` varchar(45) NOT NULL,
  `transdate` date NOT NULL,
  `transtype` varchar(45) NOT NULL,
  `qnty` int DEFAULT NULL,
  `receiver` varchar(45) DEFAULT NULL,
  `newstorage` varchar(45) DEFAULT NULL,
  `newstockhldr` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`itemcode`,`curstockhldr`,`curstorage`,`transdate`,`transtype`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblentries`
--

LOCK TABLES `tblentries` WRITE;
/*!40000 ALTER TABLE `tblentries` DISABLE KEYS */;
INSERT INTO `tblentries` VALUES ('100005','ABC Tech','ABC Tech','2022-03-02','Storage Movement',10,NULL,'XYZ Center',NULL),('1200','ABC Tech','ABC Center','2022-03-02','Stock Transfer',250,NULL,NULL,'XYZ Inc.'),('1201','ABC Tech','ABC Mini Storage','2022-03-02','Defective Item',35,NULL,NULL,NULL),('1201','ABC Tech','ABC Mini Storage','2022-03-02','Delivery',25,'Catherine',NULL,NULL),('1201','ABC Tech','ABC Mini Storage','2022-03-19','Defective Item',45,NULL,NULL,NULL),('1210','XYZ Inc','XYZ Center','2022-03-04','Stock Transfer',10,NULL,NULL,'ABC Tech'),('1210','XYZ Inc','XYZ Mini Storage','2022-03-03','Delivery',75,'Jonathan',NULL,NULL),('1210','XYZ Inc','XYZ Mini Storage','2022-03-11','Storage Movement',25,NULL,'XYZ Center',NULL),('1218','ABC Tech','Adv Center','2022-03-02','Stock Transfer',880,NULL,NULL,'XYZ Inc'),('1218','ABC Tech','Adv Center','2022-03-02','Storage Movement',320,NULL,'XYZ Center',NULL),('1218','ABC Tech','XYZ Center','2022-03-02','Delivery',20,'John Lloyd',NULL,NULL),('1227','Adv Corp','Adv Center','2022-03-02','Defective Item',65,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tblentries` ENABLE KEYS */;
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
