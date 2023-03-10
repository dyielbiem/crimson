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
-- Table structure for table `tbladditem`
--

DROP TABLE IF EXISTS `tbladditem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbladditem` (
  `itemcode` varchar(45) NOT NULL,
  `transdate` date NOT NULL,
  `storageloc` varchar(45) NOT NULL,
  `stockhldr` varchar(45) NOT NULL,
  `qnty` int DEFAULT NULL,
  PRIMARY KEY (`itemcode`,`transdate`,`storageloc`,`stockhldr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbladditem`
--

LOCK TABLES `tbladditem` WRITE;
/*!40000 ALTER TABLE `tbladditem` DISABLE KEYS */;
INSERT INTO `tbladditem` VALUES ('100005','2022-03-02','ABC Tech','ABC Tech',100),('100005','2022-03-02','ABC Tech','XYZ Inc',200),('1200','2022-03-02','ABC Center','ABC Tech',400),('1200','2022-03-03','ABC Center','ABC Tech',400),('1200','2022-03-03','XYZ Center','XYZ Inc.',300),('1200','2022-03-04','ABC Center','ABC Tech',200),('1200','2022-03-04','XYZ Center','XYZ Inc.',200),('1201','2022-03-01','ABC Center','ABC Tech',200),('1201','2022-03-01','XYZ Center','XYZ Inc',200),('1201','2022-03-02','ABC Center','ABC Tech',1400),('1201','2022-03-02','ABC Mini Storage','ABC Tech',750),('1201','2022-03-03','XYZ Center','XYZ Inc',450),('1210','2022-03-03','XYZ Mini Storage','XYZ Inc',450),('1218','2022-03-14','Adv Center','ABC Tech',600),('1218','2022-03-17','Adv Center','ABC Tech',600),('1218','2022-03-17','Adv Center','Adv Corp',350),('1227','2022-03-02','Adv Center','Adv Corp',300),('1227','2022-03-02','XYZ Center','Adv Corp',1600),('1227','2022-03-11','XYZ Center','Adv Corp',850),('1245x','2022-03-02','Tech Inc.','ABC Company `',0);
/*!40000 ALTER TABLE `tbladditem` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-10 18:04:13
