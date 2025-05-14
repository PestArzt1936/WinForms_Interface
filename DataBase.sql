-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: dashboard
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `drive`
--

DROP TABLE IF EXISTS `drive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drive` (
  `id_drive` int NOT NULL,
  `drive_name` tinytext,
  `drive_status` tinyint DEFAULT NULL,
  `id_mth` int DEFAULT NULL,
  PRIMARY KEY (`id_drive`),
  KEY `id_mth_idx` (`id_mth`),
  CONSTRAINT `id_mth` FOREIGN KEY (`id_mth`) REFERENCES `machine_tool_head` (`id_mth`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drive`
--

LOCK TABLES `drive` WRITE;
/*!40000 ALTER TABLE `drive` DISABLE KEYS */;
INSERT INTO `drive` VALUES (1,'X',1,1),(2,'Y',1,1),(3,'Z',1,1),(4,'C',1,1),(5,'X',1,3),(6,'Y',1,3),(7,'Z',0,3),(8,'C',1,3),(9,'X',0,7),(10,'Y',1,7),(11,'Z',1,7),(12,'C',1,7),(13,'X',1,8),(14,'Y',0,8),(15,'Z',1,8),(16,'C',0,8),(17,'X',1,2),(18,'Z',1,2),(19,'C\'',1,2),(20,'X',0,4),(21,'Z',1,4),(22,'C\'',1,4),(23,'X',1,5),(24,'Z',0,5),(25,'C\'',1,5),(26,'X',1,6),(27,'Z',1,6),(28,'C\'',0,6),(29,'X',1,9),(30,'Y',0,9),(31,'Z',1,9),(32,'C',0,9),(33,'X',1,10),(34,'Z',1,10),(35,'C\'',1,10);
/*!40000 ALTER TABLE `drive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_head`
--

DROP TABLE IF EXISTS `machine_tool_head`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_head` (
  `id_mth` int NOT NULL AUTO_INCREMENT,
  `head_type` tinytext,
  `id_mtn` int DEFAULT NULL,
  PRIMARY KEY (`id_mth`),
  KEY `id_mtn_load_idx` (`id_mtn`),
  CONSTRAINT `id_mtn_load` FOREIGN KEY (`id_mtn`) REFERENCES `machine_tool_name` (`id_mtn`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_head`
--

LOCK TABLES `machine_tool_head` WRITE;
/*!40000 ALTER TABLE `machine_tool_head` DISABLE KEYS */;
INSERT INTO `machine_tool_head` VALUES (1,'фрезерная',5),(2,'токарная',14),(3,'фрезерная',11),(4,'токарная',15),(5,'токарная',5),(6,'токарная',11),(7,'фрезерная',15),(8,'фрезерная',14),(9,'фрезерная',6),(10,'токарная',4),(11,'фрезерная',16);
/*!40000 ALTER TABLE `machine_tool_head` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_name`
--

DROP TABLE IF EXISTS `machine_tool_name`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_name` (
  `id_mtn` int NOT NULL,
  `machine_tool_name` tinytext,
  `id_mt` int DEFAULT NULL,
  PRIMARY KEY (`id_mtn`),
  KEY `id_mt_idx` (`id_mt`),
  CONSTRAINT `id_mt` FOREIGN KEY (`id_mt`) REFERENCES `machine_tool_type` (`id_mt`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_name`
--

LOCK TABLES `machine_tool_name` WRITE;
/*!40000 ALTER TABLE `machine_tool_name` DISABLE KEYS */;
INSERT INTO `machine_tool_name` VALUES (1,'VF-3SM',1),(2,'IRONMAC ITX-5035 ROBO',2),(3,'VF-1SM',1),(4,'KMT KTL',2),(5,'ST-30F',3),(6,'ProTech VM-1332',4),(7,'VF-2TSM',1),(8,'TM-1F',1),(9,'TM-5F',1),(10,'KMT KTL 45',2),(11,'TL-10F',3),(12,'SKM NL 1500',5),(13,'SPECTR TC-3500',5),(14,'SL40',3),(15,'ST-15F',3),(16,'SS-CN18',9);
/*!40000 ALTER TABLE `machine_tool_name` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_state`
--

DROP TABLE IF EXISTS `machine_tool_state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_state` (
  `id_mts` int NOT NULL,
  `status_type` tinytext,
  `time` tinytext,
  `channel` int DEFAULT NULL,
  `number` int DEFAULT NULL,
  `description` tinytext,
  `id_mtn` int DEFAULT NULL,
  PRIMARY KEY (`id_mts`),
  KEY `id_mtn_idx` (`id_mtn`),
  CONSTRAINT `id_mtn` FOREIGN KEY (`id_mtn`) REFERENCES `machine_tool_name` (`id_mtn`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_state`
--

LOCK TABLES `machine_tool_state` WRITE;
/*!40000 ALTER TABLE `machine_tool_state` DISABLE KEYS */;
INSERT INTO `machine_tool_state` VALUES (1,'warn','01.03.2024 08:15:30',1,101,'DriveController не инициализирован.',5),(2,'set','01.03.2024 09:30:45',2,102,'Файловая система станка в норме.',5),(3,'high','01.03.2024 10:45:15',3,103,'Останов приводов.',5),(4,'common','01.03.2024 11:20:10',4,104,'Постоянные циклы загружены успешно.',5),(5,'warn','01.03.2024 13:55:50',1,105,'Неизвестная ошибка! Exception::Unknown_error',5),(6,'set','01.03.2024 15:10:05',2,106,'Система успешно запущена.',5),(7,'high','01.03.2024 17:40:25',3,107,'Ошибка связи с контроллером.',5),(8,'common','02.03.2024 08:05:40',1,201,'Программа загрузилась успешно.',11),(9,'warn','02.03.2024 09:25:30',2,202,'Ошибка датчика температуры.',11),(10,'set','02.03.2024 10:35:15',3,203,'Конфигурация приводов завершена.',11),(11,'high','02.03.2024 11:50:50',4,204,'Критическая ошибка памяти!',11),(12,'common','02.03.2024 13:15:20',1,205,'Файловая система станка в норме.',11),(13,'warn','02.03.2024 14:45:35',2,206,'Отказ привода. Проверьте соединение.',11),(14,'high','02.03.2024 16:20:00',3,207,'Неисправность датчика давления.',11),(15,'set','03.03.2024 08:10:10',1,301,'Загрузка параметров успешно завершена.',14),(16,'warn','03.03.2024 09:55:50',2,302,'Ошибка в настройках привода.',14),(17,'high','03.03.2024 11:05:30',3,303,'Превышен температурный лимит!',14),(18,'common','03.03.2024 12:30:15',4,304,'Диагностика завершена без ошибок.',14),(19,'warn','03.03.2024 14:00:05',1,305,'Контроллер требует перезагрузки.',14),(20,'set','03.03.2024 15:35:45',2,306,'Останов в штатном режиме.',14),(21,'high','03.03.2024 17:25:20',3,307,'Аварийное отключение!',14),(22,'warn','04.03.2024 08:40:50',1,401,'Обнаружены сбои связи с контроллером.',16),(23,'set','04.03.2024 10:05:10',2,402,'Система переведена в режим ожидания.',16),(24,'high','04.03.2024 11:50:30',3,403,'Критический перегрев!',16),(25,'common','04.03.2024 13:20:05',4,404,'Проверка завершена без замечаний.',16),(26,'warn','04.03.2024 14:35:15',1,405,'Неисправность вентилятора охлаждения.',16),(27,'set','04.03.2024 16:10:45',2,406,'Калибровка завершена успешно.',16),(28,'high','04.03.2024 17:55:20',3,407,'Неустойчивое питание, возможны сбои!',16);
/*!40000 ALTER TABLE `machine_tool_state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine_tool_type`
--

DROP TABLE IF EXISTS `machine_tool_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `machine_tool_type` (
  `id_mt` int NOT NULL,
  `type` tinytext,
  PRIMARY KEY (`id_mt`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine_tool_type`
--

LOCK TABLES `machine_tool_type` WRITE;
/*!40000 ALTER TABLE `machine_tool_type` DISABLE KEYS */;
INSERT INTO `machine_tool_type` VALUES (1,'3-координатный вертикально-фрезерный'),(2,'токарный расточной'),(3,'токарно-револьверный'),(4,'вертикально-фрезерный с поворотным столом и поворотной головой'),(5,'токарный обрабатывающий центр'),(6,'токарный с противошпинделем'),(7,'токарный с противошпинделем и фрезерной головкой'),(8,'вертикально-фрезерный с поворотным столом'),(9,'сверлильный');
/*!40000 ALTER TABLE `machine_tool_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `position`
--

DROP TABLE IF EXISTS `position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `position` (
  `id_pos` int NOT NULL,
  `value` tinytext,
  `id_drive` int DEFAULT NULL,
  PRIMARY KEY (`id_pos`),
  KEY `id_drive_idx` (`id_drive`),
  CONSTRAINT `id_drive` FOREIGN KEY (`id_drive`) REFERENCES `drive` (`id_drive`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'12.5 ',1),(2,'18.9',2),(3,'8.3 ',3),(4,'45° 30\' 15\"',4),(5,'-5.2 ',5),(6,'7.1 ',6),(7,'21.2',7),(8,'32° 02\' 14\"',8),(9,'4.0 ',9),(10,'-3.1',10),(11,'-2.5',11),(12,'90° 0\' 0\"',12),(13,'6.7 ',13),(14,'-3.9',14),(15,'-8.5',15),(16,'180° 45\' 10\"',16),(17,'-10.0 ',17),(18,'5.2',18),(19,'30° 15\' 0\"',19),(20,'5.5 ',20),(21,'6.7',21),(22,'120° 5\' 20\"',22),(23,'-8.7 ',23),(24,'18.9',24),(25,'60° 30\' 45\"',25),(26,'11.2 ',26),(27,'0 ',27),(28,'15° 0\' 0\"',28),(29,'9.8 ',29),(30,'10.7',30),(31,'14.3 ',31),(32,'0° 30\' 10\"',32),(33,'-12.5 ',33),(34,'16.1',34),(35,'45° 20\' 5\"',35);
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `temperature`
--

DROP TABLE IF EXISTS `temperature`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `temperature` (
  `id_temp` int NOT NULL,
  `current_temp` int DEFAULT NULL,
  `max_temp` int DEFAULT NULL,
  `time` tinytext,
  `id_drive` int DEFAULT NULL,
  PRIMARY KEY (`id_temp`),
  KEY `id_drive_idx` (`id_drive`),
  CONSTRAINT `id_drive1` FOREIGN KEY (`id_drive`) REFERENCES `drive` (`id_drive`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `temperature`
--

LOCK TABLES `temperature` WRITE;
/*!40000 ALTER TABLE `temperature` DISABLE KEYS */;
INSERT INTO `temperature` VALUES (1,45,60,'01.03.2024 08:00:00',4),(2,47,60,'01.03.2024 10:00:00',4),(3,49,60,'01.03.2024 12:00:00',4),(4,50,60,'01.03.2024 14:00:00',4),(5,52,60,'01.03.2024 16:00:00',4),(6,55,60,'01.03.2024 18:00:00',4),(7,48,60,'01.03.2024 08:00:00',8),(8,50,60,'01.03.2024 10:00:00',8),(9,52,60,'01.03.2024 12:00:00',8),(10,54,60,'01.03.2024 14:00:00',8),(11,56,60,'01.03.2024 16:00:00',8),(12,58,60,'01.03.2024 18:00:00',8),(13,46,60,'02.03.2024 08:00:00',12),(14,48,60,'02.03.2024 10:00:00',12),(15,50,60,'02.03.2024 12:00:00',12),(16,52,60,'02.03.2024 14:00:00',12),(17,54,60,'02.03.2024 16:00:00',12),(18,56,60,'02.03.2024 18:00:00',12),(19,47,60,'02.03.2024 08:00:00',16),(20,49,60,'02.03.2024 10:00:00',16),(21,51,60,'02.03.2024 12:00:00',16),(22,53,60,'02.03.2024 14:00:00',16),(23,55,60,'02.03.2024 16:00:00',16),(24,57,60,'02.03.2024 18:00:00',16),(25,48,60,'02.03.2024 08:00:00',19),(26,50,60,'02.03.2024 10:00:00',19),(27,52,60,'02.03.2024 12:00:00',19),(28,54,60,'02.03.2024 14:00:00',19),(29,56,60,'02.03.2024 16:00:00',19),(30,58,60,'02.03.2024 18:00:00',19),(31,48,60,'02.03.2024 08:00:00',22),(32,50,60,'02.03.2024 10:00:00',22),(33,52,60,'02.03.2024 12:00:00',22),(34,54,60,'02.03.2024 14:00:00',22),(35,56,60,'02.03.2024 16:00:00',22),(36,58,60,'02.03.2024 18:00:00',22),(37,49,60,'02.03.2024 08:00:00',25),(38,51,60,'02.03.2024 10:00:00',25),(39,53,60,'02.03.2024 12:00:00',25),(40,55,60,'02.03.2024 14:00:00',25),(41,57,60,'02.03.2024 16:00:00',25),(42,59,60,'02.03.2024 18:00:00',25),(43,48,60,'02.03.2024 08:00:00',28),(44,50,60,'02.03.2024 10:00:00',28),(45,52,60,'02.03.2024 12:00:00',28),(46,54,60,'02.03.2024 14:00:00',28),(47,56,60,'02.03.2024 16:00:00',28),(48,58,60,'02.03.2024 18:00:00',28),(49,50,60,'02.03.2024 08:00:00',32),(50,52,60,'02.03.2024 10:00:00',32),(51,54,60,'02.03.2024 12:00:00',32),(52,56,60,'02.03.2024 14:00:00',32),(53,58,60,'02.03.2024 16:00:00',32),(54,60,60,'02.03.2024 18:00:00',32),(55,53,60,'02.03.2024 08:00:00',35),(56,55,60,'02.03.2024 10:00:00',35),(57,57,60,'02.03.2024 12:00:00',35),(58,59,60,'02.03.2024 14:00:00',35),(59,61,60,'02.03.2024 16:00:00',35),(60,63,60,'02.03.2024 18:00:00',35),(61,45,60,'01.03.2024 08:00:00',1),(62,47,60,'01.03.2024 10:00:00',1),(63,46,60,'01.03.2024 08:00:00',2),(64,48,60,'01.03.2024 10:00:00',2),(65,44,60,'01.03.2024 08:00:00',3),(66,46,60,'01.03.2024 10:00:00',3),(67,46,60,'01.03.2024 08:00:00',6),(68,48,60,'01.03.2024 10:00:00',6),(69,49,60,'01.03.2024 08:00:00',7),(70,50,60,'01.03.2024 10:00:00',7),(71,46,60,'01.03.2024 08:00:00',11),(72,48,60,'01.03.2024 10:00:00',11),(73,47,60,'01.03.2024 08:00:00',13),(74,49,60,'01.03.2024 10:00:00',13),(75,48,60,'01.03.2024 08:00:00',15),(76,50,60,'01.03.2024 10:00:00',15),(77,46,60,'01.03.2024 08:00:00',17),(78,48,60,'01.03.2024 10:00:00',17),(81,47,60,'01.03.2024 08:00:00',20),(82,49,60,'01.03.2024 10:00:00',20),(83,45,60,'01.03.2024 08:00:00',23),(84,47,60,'01.03.2024 10:00:00',23),(85,46,60,'01.03.2024 08:00:00',24),(86,48,60,'01.03.2024 10:00:00',24),(87,46,60,'01.03.2024 08:00:00',5),(88,48,60,'01.03.2024 10:00:00',5),(89,47,60,'01.03.2024 12:00:00',5),(90,49,60,'01.03.2024 14:00:00',5),(91,51,60,'01.03.2024 16:00:00',5),(92,47,60,'01.03.2024 08:00:00',9),(93,49,60,'01.03.2024 10:00:00',9),(94,51,60,'01.03.2024 12:00:00',9),(95,52,60,'01.03.2024 14:00:00',9),(96,46,60,'01.03.2024 08:00:00',10),(97,48,60,'01.03.2024 10:00:00',10),(98,50,60,'01.03.2024 12:00:00',10),(99,52,60,'01.03.2024 14:00:00',10);
/*!40000 ALTER TABLE `temperature` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-14 17:41:23
