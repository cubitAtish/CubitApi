-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: cubit
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `authtoken`
--

DROP TABLE IF EXISTS `authtoken`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `authtoken` (
  `token_id` int(11) NOT NULL AUTO_INCREMENT,
  `token_key` varchar(200) DEFAULT NULL,
  `token_expiry` datetime DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `crdate` datetime DEFAULT NULL,
  PRIMARY KEY (`token_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authtoken`
--

LOCK TABLES `authtoken` WRITE;
/*!40000 ALTER TABLE `authtoken` DISABLE KEYS */;
/*!40000 ALTER TABLE `authtoken` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `city` (
  `city_id` int(11) NOT NULL AUTO_INCREMENT,
  `city_name` varchar(45) NOT NULL,
  `city_stateid` int(11) NOT NULL,
  `city_isactive` tinyint(1) NOT NULL,
  PRIMARY KEY (`city_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'Bangalore',17,1),(2,'Belgaum',17,1),(3,'Mysore',17,1),(4,'Tumkur',17,1),(5,'Gulbarga',17,1),(6,'Bellary',17,1),(7,'Bijapur',17,1),(8,'Dakshina Kannada',17,1),(9,'Davanagere	',17,1),(10,'Raichur',17,1),(11,'Bagalkot',17,1),(12,'Dharwad',17,1),(13,'Mandya',17,1),(14,'Hassan',17,1),(15,'Shimoga',17,1),(16,'Bidar',17,1),(17,'Chitradurga',17,1),(18,'Haveri',17,1),(19,'Kolar',17,1),(20,'Uttara Kannada',17,1),(21,'Koppal',17,1),(22,'Chikkaballapura',17,1),(23,'Udupi',17,1),(24,'Yadgir',17,1),(25,'Chikmagalur',17,1),(26,'Ramanagara',17,1),(27,'Gadag',17,1),(28,'Chamarajanagar',17,1),(29,'Bangalore Rural',17,1),(30,'Kodagu',17,1);
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class` (
  `class_id` int(11) NOT NULL AUTO_INCREMENT,
  `class_name` varchar(45) DEFAULT NULL,
  `class_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`class_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class`
--

LOCK TABLES `class` WRITE;
/*!40000 ALTER TABLE `class` DISABLE KEYS */;
INSERT INTO `class` VALUES (1,'1st',''),(2,'2nd',''),(3,'3rd',''),(4,'4th',''),(5,'5th',NULL),(6,'6th',NULL),(7,'7th',NULL),(8,'8th',NULL),(9,'9th',NULL),(10,'10th',NULL),(11,'1st PUC',NULL),(12,'2nd PUC',NULL),(13,'B.com',NULL),(14,'B.sc',NULL),(15,'BCA',NULL);
/*!40000 ALTER TABLE `class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `country` (
  `country_id` int(11) NOT NULL AUTO_INCREMENT,
  `country_name` varchar(45) DEFAULT NULL,
  `country_isactive` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`country_id`)
) ENGINE=InnoDB AUTO_INCREMENT=205 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES (1,'Afghanistan',1),(2,'Albania',1),(3,'Algeria',1),(4,'Andorra',1),(5,'Angola',1),(6,'Antigua and Barbuda',1),(7,'Argentina',1),(8,'Armenia',1),(9,'Aruba',1),(10,'Australia',1),(11,'Austria',1),(12,'Azerbaijan',1),(13,'Bahama',1),(14,'Bahrain',1),(15,'Bangladesh',1),(16,'Barbados',1),(17,'Belarus',1),(18,'Belgium',1),(19,'Belize',1),(20,'Benin',1),(21,'Bhutan',1),(22,'Bolivia',1),(23,'Bosnia and Herzegovina',1),(24,'Botswana',1),(25,'Brazil',1),(26,'Brunei ',1),(27,'Bulgaria',1),(28,'Burkina Faso',1),(29,'Burma',1),(30,'Burundi',1),(31,'Cambodia',1),(32,'Cameroon',1),(33,'Canada',1),(34,'Cabo Verde',1),(35,'Central African Republic',1),(36,'Chad',1),(37,'Chile',1),(38,'China',1),(39,'Colombia',1),(40,'Comoros',1),(41,'Congo',1),(42,'Costa Rica',1),(43,'Cote d\'Ivoire',1),(44,'Croatia',1),(45,'Cuba',1),(46,'Curacao',1),(47,'Cyprus',1),(48,'Czech Republic',1),(49,'Denmark',1),(50,'Djibouti',1),(51,'Dominica',1),(52,'Dominican Republic',1),(53,'East Timor',1),(54,'Ecuador',1),(55,'Egypt',1),(56,'El Salvador',1),(57,'Equatorial Guinea',1),(58,'Eritrea',1),(59,'Estonia',1),(60,'Ethiopia',1),(61,'Fiji',1),(62,'Finland',1),(63,'France',1),(64,'Gabon',1),(65,'Gambia',1),(66,'Georgia',1),(67,'Germany',1),(68,'Ghana',1),(69,'Greece',1),(70,'Grenada',1),(71,'Guatemala',1),(72,'Guinea',1),(73,'Guinea-Bissau',1),(74,'Guyana',1),(75,'Haiti',1),(76,'Holy See',1),(77,'Honduras',1),(78,'Hong Kong',1),(79,'Hungary',1),(80,'Iceland',1),(81,'India',1),(82,'Indonesia',1),(83,'Iran',1),(84,'Iraq',1),(85,'Ireland',1),(86,'Israel',1),(87,'Italy',1),(88,'Jamaica',1),(89,'Japan',1),(90,'Jordan',1),(91,'Kazakhstan',1),(92,'Kenya',1),(93,'Kiribati',1),(94,'Korea, North',1),(95,'Korea, South',1),(96,'Kosovo',1),(97,'Kuwait',1),(98,'Kyrgyzstan',1),(99,'Laos',1),(100,'Latvia',1),(101,'Lebanon',1),(102,'Lesotho',1),(103,'Liberia',1),(104,'Libya',1),(105,'Liechtenstein',1),(106,'Lithuania',1),(107,'Luxembourg',1),(108,'Macau',1),(109,'Macedonia',1),(110,'Madagascar',1),(111,'Malawi',1),(112,'Malaysia',1),(113,'Maldives',1),(114,'Mali',1),(115,'Malta',1),(116,'Marshall Islands',1),(117,'Mauritania',1),(118,'Mauritius',1),(119,'Mexico',1),(120,'Micronesia',1),(121,'Moldova',1),(122,'Monaco',1),(123,'Mongolia',1),(124,'Montenegro',1),(125,'Morocco',1),(126,'Mozambique',1),(127,'Namibia',1),(128,'Nauru',1),(129,'Nepal',1),(130,'Netherlands',1),(131,'Netherlands Antilles',1),(132,'New Zealand',1),(133,'Nicaragua',1),(134,'Niger',1),(135,'Nigeria',1),(136,'North Korea',1),(137,'Norway',1),(138,'Oman',1),(139,'Pakistan',1),(140,'Palau',1),(141,'Palestinian Territories',1),(142,'Panama',1),(143,'Papua New Guinea',1),(144,'Paraguay',1),(145,'Peru',1),(146,'Philippines',1),(147,'Poland',1),(148,'Portugal',1),(149,'Qatar',1),(150,'Romania',1),(151,'Russia',1),(152,'Rwanda',1),(153,'Saint Kitts and Nevis',1),(154,'Saint Lucia',1),(155,'Saint Vincent and the Grenadines',1),(156,'Samoa ',1),(157,'San Marino',1),(158,'Sao Tome and Principe',1),(159,'Saudi Arabia',1),(160,'Senegal',1),(161,'Serbia',1),(162,'Seychelles',1),(163,'Sierra Leone',1),(164,'Singapore',1),(165,'Sint Maarten',1),(166,'Slovakia',1),(167,'Slovenia',1),(168,'Solomon Islands',1),(169,'Somalia',1),(170,'South Africa',1),(171,'South Korea',1),(172,'South Sudan',1),(173,'Spain ',1),(174,'Sri Lanka',1),(175,'Sudan',1),(176,'Suriname',1),(177,'Swaziland ',1),(178,'Sweden',1),(179,'Switzerland',1),(180,'Syria',1),(181,'Taiwan',1),(182,'Tajikistan',1),(183,'Tanzania',1),(184,'Thailand ',1),(185,'Timor-Leste',1),(186,'Togo',1),(187,'Tonga',1),(188,'Trinidad and Tobago',1),(189,'Tunisia',1),(190,'Turkey',1),(191,'Turkmenistan',1),(192,'Tuvalu',1),(193,'Uganda',1),(194,'Ukraine',1),(195,'United Arab Emirates',1),(196,'United Kingdom',1),(197,'Uruguay',1),(198,'Uzbekistan',1),(199,'Vanuatu',1),(200,'Venezuela',1),(201,'Vietnam',1),(202,'Yemen',1),(203,'Zambia',1),(204,'Zimbabwe',1);
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `document`
--

DROP TABLE IF EXISTS `document`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `document` (
  `doc_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `doc_url` varchar(100) NOT NULL,
  `doc_name` varchar(100) DEFAULT NULL,
  `doc_description` varchar(100) DEFAULT NULL,
  `doc_uploaddate` datetime NOT NULL,
  `doc_extension` varchar(5) NOT NULL,
  `doc_size` varchar(15) NOT NULL,
  PRIMARY KEY (`doc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='save files,photos,videos';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `document`
--

LOCK TABLES `document` WRITE;
/*!40000 ALTER TABLE `document` DISABLE KEYS */;
INSERT INTO `document` VALUES (1,3,'https://cubit-4a35f.firebaseapp.com/document/profile_pic/pic.png','pic','its cat','2016-08-02 00:00:00','png','1214440');
/*!40000 ALTER TABLE `document` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventpost`
--

DROP TABLE IF EXISTS `eventpost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eventpost` (
  `event_id` int(11) NOT NULL AUTO_INCREMENT,
  `event_title` varchar(100) DEFAULT NULL,
  `event_description` varchar(500) DEFAULT NULL,
  `event_startdate` datetime DEFAULT NULL,
  `event_enddate` datetime DEFAULT NULL,
  `event_document_id` varchar(50) DEFAULT NULL COMMENT 'store document IDs with a (,) operator',
  `event_gpslocation_id` varchar(50) DEFAULT NULL COMMENT 'store GPSLocation IDs with a (,) operator',
  `event_venue` varchar(100) DEFAULT NULL,
  `event_user_type` int(2) DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventpost`
--

LOCK TABLES `eventpost` WRITE;
/*!40000 ALTER TABLE `eventpost` DISABLE KEYS */;
INSERT INTO `eventpost` VALUES (1,'Inter cricket event','please every reva students should be in cricket stadium at 10AM on 24th of this month','2016-11-24 00:00:00','2016-11-25 00:00:00',NULL,NULL,'reva cricket stadium, yellahnka ',4,14),(2,'revamp','Invitation to all colleges to please take partisipate our college fest of revamp','2016-11-28 00:00:00','2016-12-04 00:00:00',NULL,NULL,'reva campus',4,14);
/*!40000 ALTER TABLE `eventpost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examreportmapping`
--

DROP TABLE IF EXISTS `examreportmapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examreportmapping` (
  `erm_id` int(11) NOT NULL AUTO_INCREMENT,
  `erm_section_id` int(11) DEFAULT NULL,
  `erm_class_id` int(11) DEFAULT NULL,
  `erm_institution_id` int(11) NOT NULL,
  `exam_term` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`erm_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examreportmapping`
--

LOCK TABLES `examreportmapping` WRITE;
/*!40000 ALTER TABLE `examreportmapping` DISABLE KEYS */;
INSERT INTO `examreportmapping` VALUES (1,1,3,2,'1st'),(2,2,2,2,'1st');
/*!40000 ALTER TABLE `examreportmapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examschedule`
--

DROP TABLE IF EXISTS `examschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `examschedule` (
  `examsec_id` int(11) NOT NULL AUTO_INCREMENT,
  `erm_id` int(11) DEFAULT NULL,
  `subject_id` int(11) NOT NULL,
  `subject_name` varchar(100) NOT NULL,
  `exam_date` datetime NOT NULL,
  `exam_term` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`examsec_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examschedule`
--

LOCK TABLES `examschedule` WRITE;
/*!40000 ALTER TABLE `examschedule` DISABLE KEYS */;
/*!40000 ALTER TABLE `examschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `friends`
--

DROP TABLE IF EXISTS `friends`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `friends` (
  `friends_id` int(11) NOT NULL AUTO_INCREMENT,
  `from_user_id` int(11) NOT NULL,
  `to_user_id` int(11) NOT NULL,
  PRIMARY KEY (`friends_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `friends`
--

LOCK TABLES `friends` WRITE;
/*!40000 ALTER TABLE `friends` DISABLE KEYS */;
INSERT INTO `friends` VALUES (1,3,4),(2,3,5),(3,3,6),(4,4,5),(5,4,7);
/*!40000 ALTER TABLE `friends` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gpslocation`
--

DROP TABLE IF EXISTS `gpslocation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gpslocation` (
  `gpslocation_id` int(11) NOT NULL AUTO_INCREMENT,
  `gpslocation_discription` varchar(100) DEFAULT NULL,
  `gpslocation_name` varchar(100) DEFAULT NULL,
  `gpslocation_location` varchar(50) NOT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`gpslocation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='GPS location address(longitude+latitude)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gpslocation`
--

LOCK TABLES `gpslocation` WRITE;
/*!40000 ALTER TABLE `gpslocation` DISABLE KEYS */;
/*!40000 ALTER TABLE `gpslocation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `group`
--

DROP TABLE IF EXISTS `group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `group` (
  `group_id` int(11) NOT NULL AUTO_INCREMENT,
  `group_name` varchar(35) DEFAULT NULL,
  `group_isactive` tinyint(1) NOT NULL,
  `group_description` longtext,
  `group_privacy` int(11) DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`group_id`),
  KEY `user_id_idx` (`user_id`),
  CONSTRAINT `user_id` FOREIGN KEY (`user_id`) REFERENCES `userinfo` (`user_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table holding group details ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `group`
--

LOCK TABLES `group` WRITE;
/*!40000 ALTER TABLE `group` DISABLE KEYS */;
/*!40000 ALTER TABLE `group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `homework`
--

DROP TABLE IF EXISTS `homework`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `homework` (
  `homework_id` int(11) NOT NULL AUTO_INCREMENT,
  `hw_institution_id` int(11) NOT NULL,
  `hw_section_id` int(11) DEFAULT NULL,
  `hw_class_id` int(11) DEFAULT NULL,
  `hw_teacher_id` int(11) DEFAULT NULL,
  `hw_subject_id` int(11) NOT NULL,
  `hw_description` varchar(100) DEFAULT NULL,
  `hw_date` datetime NOT NULL,
  `isactive` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`homework_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `homework`
--

LOCK TABLES `homework` WRITE;
/*!40000 ALTER TABLE `homework` DISABLE KEYS */;
/*!40000 ALTER TABLE `homework` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `homeworkupload`
--

DROP TABLE IF EXISTS `homeworkupload`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `homeworkupload` (
  `homeworkupload_id` int(11) NOT NULL AUTO_INCREMENT,
  `homework_id` int(11) NOT NULL,
  `hw_student_id` int(11) NOT NULL,
  `hw_url` varchar(100) DEFAULT NULL,
  `isactive` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`homeworkupload_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `homeworkupload`
--

LOCK TABLES `homeworkupload` WRITE;
/*!40000 ALTER TABLE `homeworkupload` DISABLE KEYS */;
/*!40000 ALTER TABLE `homeworkupload` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `instclssectionmapping`
--

DROP TABLE IF EXISTS `instclssectionmapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `instclssectionmapping` (
  `instclssection_id` int(11) NOT NULL AUTO_INCREMENT,
  `institution_id` int(11) NOT NULL,
  `class_id` int(11) NOT NULL,
  `section_id` int(11) NOT NULL,
  `instclssection_strength` int(11) DEFAULT NULL,
  `instclssection_teacher_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`instclssection_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `instclssectionmapping`
--

LOCK TABLES `instclssectionmapping` WRITE;
/*!40000 ALTER TABLE `instclssectionmapping` DISABLE KEYS */;
/*!40000 ALTER TABLE `instclssectionmapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `institution`
--

DROP TABLE IF EXISTS `institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `institution` (
  `institution_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `institution_country` int(11) NOT NULL,
  `institution_state` int(11) NOT NULL,
  `institution_city` int(11) NOT NULL,
  `institution_name` varchar(65) NOT NULL,
  `institution_address` varchar(200) DEFAULT NULL,
  `institution_website` varchar(100) DEFAULT NULL,
  `institution_poc` varchar(45) NOT NULL,
  `institution_nostudents` int(4) DEFAULT NULL,
  `institution_class_id` int(11) NOT NULL,
  PRIMARY KEY (`institution_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `institution`
--

LOCK TABLES `institution` WRITE;
/*!40000 ALTER TABLE `institution` DISABLE KEYS */;
INSERT INTO `institution` VALUES (1,14,81,17,1,'The Valley School','Thatguni Post, Kanakapura Road, Pincode: 560062, Kanakapura Road','www.thevalleyschool.info','test_personofcontact',789,13),(2,15,81,17,1,'Indus International School','Billapura Cross, Sarjapur, Pincode: 562125, Sarjapur Road','www.indusschool.com','test_personofcontact',656,14),(3,16,81,17,1,'Mallya Aditi International School','Behind NIPCCD Building, Yelahanka New Town, Pincode: 560106, Yelahanka','www.aditi.edu.in','test_personofcontact',443,15),(4,0,81,17,1,'Vidya Niketan School','# 30, Kempapura, Hebbal, , Pincode: 560024, Hebbal','www.vidyaniketanhebbal.org','test_personofcontact',343,13),(5,0,81,17,1,'St. Joseph’s Boys’ High School','27, Museum Road, , Pincode: 560025, Museum Road','www.sjbhsbangalore.in','test_personofcontact',343,13),(6,0,81,17,1,'Sarala Birla Academy','Bannerghatta, Jigni Road, Pincode: 560083, Bannerghatta Road','www.saralabirlaacademy.org','test_personofcontact',454,14),(7,0,81,17,1,'Christ University','Hosur Road, , Bangalore, Karnataka - 560029','www.christcollege.edu','test_personofcontact',233,12),(8,0,81,17,1,'Presidency College','Kempapura, Hebbal, Bangalore, Karnataka - 560024','www.presidencycollege.ac.in','test_personofcontact',878,11),(9,0,81,17,1,'Reva Institute of Technology and Management',' Rukmini Knowledge Park, Kattigenahalli,Yelahanka','www.revainstitution.org','test_personofcontact',454,14);
/*!40000 ALTER TABLE `institution` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parent`
--

DROP TABLE IF EXISTS `parent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parent` (
  `parent_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `parent_childeren` varchar(45) DEFAULT NULL COMMENT 'store child IDs with a (,) operator',
  `parent_occupation` varchar(45) DEFAULT NULL,
  `parent_nameofspouse` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`parent_id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`),
  CONSTRAINT `parent_user_id` FOREIGN KEY (`user_id`) REFERENCES `userinfo` (`user_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parent`
--

LOCK TABLES `parent` WRITE;
/*!40000 ALTER TABLE `parent` DISABLE KEYS */;
/*!40000 ALTER TABLE `parent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `periodtimetable`
--

DROP TABLE IF EXISTS `periodtimetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `periodtimetable` (
  `pttable_id` int(11) NOT NULL AUTO_INCREMENT,
  `timetable_id` int(11) DEFAULT NULL,
  `starttime` varchar(7) DEFAULT NULL,
  `endtime` varchar(7) DEFAULT NULL,
  `period_no` int(2) DEFAULT NULL,
  `teacher_name` varchar(100) DEFAULT NULL,
  `day` varchar(9) DEFAULT NULL,
  `subject` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`pttable_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `periodtimetable`
--

LOCK TABLES `periodtimetable` WRITE;
/*!40000 ALTER TABLE `periodtimetable` DISABLE KEYS */;
INSERT INTO `periodtimetable` VALUES (1,1,'8:30','9:30',1,'tec_girish','monday','maths'),(2,1,'9:30','10:30',2,'tec_girish','monday','science'),(3,1,'11:30','12:30',3,'tec_suresh','monday','biology');
/*!40000 ALTER TABLE `periodtimetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `post`
--

DROP TABLE IF EXISTS `post`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `post` (
  `post_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `post_doc_id` varchar(50) DEFAULT NULL COMMENT 'store document IDs with a (,) operator',
  `post_gpslocation_id` varchar(50) DEFAULT NULL COMMENT 'store GPS location IDs with a (,) operator',
  `post_date` datetime DEFAULT NULL,
  `post_user_type` int(2) DEFAULT NULL,
  `post_feeds` varchar(200) DEFAULT NULL,
  `post_tag_user_id` varchar(100) DEFAULT NULL COMMENT 'store tag_user IDs with a (,) operator',
  `post_event_id` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`post_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `post`
--

LOCK TABLES `post` WRITE;
/*!40000 ALTER TABLE `post` DISABLE KEYS */;
/*!40000 ALTER TABLE `post` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quizquestions`
--

DROP TABLE IF EXISTS `quizquestions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quizquestions` (
  `ques_id` int(11) NOT NULL AUTO_INCREMENT,
  `erm_id` int(11) NOT NULL,
  `teacher_id` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `question` varchar(200) NOT NULL,
  `choices` varchar(300) DEFAULT NULL,
  `answer` varchar(100) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ques_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quizquestions`
--

LOCK TABLES `quizquestions` WRITE;
/*!40000 ALTER TABLE `quizquestions` DISABLE KEYS */;
INSERT INTO `quizquestions` VALUES (1,1,11,1,'Imminent','Impure,upcoming,Unsteady,Proud','upcoming',1),(2,1,11,1,'Frugal','explore,invention,economical,to whisper','economical',1),(3,1,11,1,'Kernel','expose,hungry,impose,core','core',1),(4,1,11,1,'Gelid','extremely cold,soft,hard headed,talkative','extremely cold',1);
/*!40000 ALTER TABLE `quizquestions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quizresult`
--

DROP TABLE IF EXISTS `quizresult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quizresult` (
  `qui_res_id` int(11) NOT NULL AUTO_INCREMENT,
  `erm_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `ques_id` int(11) DEFAULT NULL,
  `select_ans` varchar(100) DEFAULT NULL,
  `result` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`qui_res_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quizresult`
--

LOCK TABLES `quizresult` WRITE;
/*!40000 ALTER TABLE `quizresult` DISABLE KEYS */;
INSERT INTO `quizresult` VALUES (1,1,4,1,1,'Proud',NULL),(2,1,4,1,2,'economical',NULL),(3,1,4,1,3,'core',NULL),(4,1,4,1,4,'talkative',NULL);
/*!40000 ALTER TABLE `quizresult` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportcard`
--

DROP TABLE IF EXISTS `reportcard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reportcard` (
  `recard_id` int(11) NOT NULL,
  `erm_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `marks` int(4) NOT NULL,
  `grade` varchar(2) NOT NULL,
  `erm_term` varchar(6) DEFAULT NULL,
  `subject_id` int(11) NOT NULL,
  PRIMARY KEY (`recard_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportcard`
--

LOCK TABLES `reportcard` WRITE;
/*!40000 ALTER TABLE `reportcard` DISABLE KEYS */;
/*!40000 ALTER TABLE `reportcard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requeststatus`
--

DROP TABLE IF EXISTS `requeststatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requeststatus` (
  `requeststatus_id` int(11) NOT NULL AUTO_INCREMENT,
  `request_from` int(11) NOT NULL,
  `request_to` int(11) NOT NULL,
  `request_status` smallint(1) NOT NULL COMMENT '0- pending, 1- approved, 2- reject ',
  `request_for_group` int(11) NOT NULL,
  `request_note` text,
  `request_crdate` datetime NOT NULL,
  `request_upddate` datetime DEFAULT NULL,
  PRIMARY KEY (`requeststatus_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COMMENT='consists info about request ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requeststatus`
--

LOCK TABLES `requeststatus` WRITE;
/*!40000 ALTER TABLE `requeststatus` DISABLE KEYS */;
INSERT INTO `requeststatus` VALUES (1,3,4,1,1,'testnote','2016-05-05 00:00:00','2016-05-05 00:00:00'),(2,3,5,1,4,'test','2016-08-19 15:59:57','2016-05-05 00:00:00'),(3,3,6,1,1,'test','2016-08-19 15:59:57','2016-05-05 00:00:00'),(4,3,7,0,1,'test','2016-08-19 15:59:57','2016-05-05 00:00:00'),(5,4,5,1,1,'test','2016-08-19 15:59:57','2016-05-05 00:00:00'),(6,4,6,0,1,'test','2016-08-19 15:59:57','2016-05-05 00:00:00'),(7,4,7,1,1,'test','2016-08-19 15:59:57','2016-08-19 15:59:57');
/*!40000 ALTER TABLE `requeststatus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section`
--

DROP TABLE IF EXISTS `section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `section` (
  `section_id` int(11) NOT NULL AUTO_INCREMENT,
  `section_name` varchar(45) DEFAULT NULL,
  `section_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`section_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section`
--

LOCK TABLES `section` WRITE;
/*!40000 ALTER TABLE `section` DISABLE KEYS */;
INSERT INTO `section` VALUES (1,'A','rabindranath tagore'),(2,'B','rabindranath tagore'),(3,'C','rabindranath tagore');
/*!40000 ALTER TABLE `section` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sectsubjmapping`
--

DROP TABLE IF EXISTS `sectsubjmapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sectsubjmapping` (
  `sectsubjmapping_id` int(11) NOT NULL AUTO_INCREMENT,
  `instclssection_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  PRIMARY KEY (`sectsubjmapping_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sectsubjmapping`
--

LOCK TABLES `sectsubjmapping` WRITE;
/*!40000 ALTER TABLE `sectsubjmapping` DISABLE KEYS */;
/*!40000 ALTER TABLE `sectsubjmapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `state`
--

DROP TABLE IF EXISTS `state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `state` (
  `state_id` int(11) NOT NULL AUTO_INCREMENT,
  `state_name` varchar(100) DEFAULT NULL,
  `state_countryid` int(11) DEFAULT NULL,
  `state_isactive` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`state_id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `state`
--

LOCK TABLES `state` WRITE;
/*!40000 ALTER TABLE `state` DISABLE KEYS */;
INSERT INTO `state` VALUES (1,'Andaman and Nicobar Islands',81,1),(2,'Andhra Pradesh',81,1),(3,'Arunachal Pradesh',81,1),(4,'Assam',81,1),(5,'Bihar',81,1),(6,'Chandigarh',81,1),(7,'Chhattisgarh',81,1),(8,'Dadra and Nagar Haveli ',81,1),(9,'Daman and Diu',81,1),(10,'Delhi ',81,1),(11,'Goa',81,1),(12,'Gujarat',81,1),(13,'Haryana',81,1),(14,'Himachal Pradesh',81,1),(15,'Jammu and Kashmir',81,1),(16,'Jharkhand',81,1),(17,'Karnataka',81,1),(18,'Kerala',81,1),(19,'Lakshadweep ',81,1),(20,'Madhya Pradesh',81,1),(21,'Maharashtra',81,1),(22,'Manipur',81,1),(23,'Meghalaya',81,1),(24,'Mizoram',81,1),(25,'Nagaland',81,1),(26,'Odisha',81,1),(27,'Puducherry',81,1),(28,'Punjab',81,1),(29,'Rajasthan',81,1),(30,'Sikkim',81,1),(31,'Tamil Nadu',81,1),(32,'Telangana',81,1),(33,'Tripura',81,1),(34,'Uttar Pradesh',81,1),(35,'Uttarakhand',81,1),(36,'West Bengal',81,1);
/*!40000 ALTER TABLE `state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `student_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `student_father_name` varchar(100) DEFAULT NULL,
  `student_mother_name` varchar(100) DEFAULT NULL,
  `student_regid` varchar(45) NOT NULL,
  `student_roll_no` int(11) NOT NULL,
  `student_section` int(11) DEFAULT NULL,
  `student_class` int(11) NOT NULL,
  `student_institution_id` int(11) NOT NULL,
  `student_cca` varchar(200) DEFAULT NULL,
  `student_eca` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`student_id`),
  KEY `student_user_id_idx` (`user_id`),
  KEY `student_class_id_idx` (`student_class`),
  CONSTRAINT `student_class_id` FOREIGN KEY (`student_class`) REFERENCES `class` (`class_id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `student_user_id` FOREIGN KEY (`user_id`) REFERENCES `userinfo` (`user_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,3,'sathish','likitha','1cu12mca20',12,1,1,14,'test_cca','test_eca'),(2,4,'srikanth','swathi','1pd12mca22',23,1,1,14,'test_cca','test_eca'),(3,5,'shankar','monika','1ry12mca45',2,1,2,14,'test_cca','test_eca'),(4,6,'balraj','ankitha','1ry12mca43',24,1,3,15,'test_cca','test_eca'),(5,7,'lakshman','ashvini','1ry12mca20',12,1,4,14,'test_cca','test_eca');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL AUTO_INCREMENT,
  `subject_name` varchar(45) NOT NULL,
  `subject_syllabus` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`subject_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (1,'english','eglish part 1'),(2,'social','philosophy'),(3,'social','history'),(4,'science','chemistry'),(5,'science','phisics'),(6,'science','biology');
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teacher` (
  `teacher_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `teacher_code` varchar(45) DEFAULT NULL,
  `teacher_institution_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`teacher_id`),
  KEY `teacher_user_id_idx` (`user_id`),
  CONSTRAINT `teacher_user_id` FOREIGN KEY (`user_id`) REFERENCES `userpersonalinfo` (`userper_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (1,11,'math1',1),(2,12,'english',1),(3,13,'science',1);
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `timetable`
--

DROP TABLE IF EXISTS `timetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `timetable` (
  `timetable_id` int(11) NOT NULL AUTO_INCREMENT,
  `class_id` int(11) DEFAULT NULL,
  `section_id` int(11) DEFAULT NULL,
  `institution_id` int(11) NOT NULL,
  `isactive` tinyint(1) DEFAULT NULL,
  `createdby` varchar(100) DEFAULT NULL,
  `createddate` datetime DEFAULT NULL,
  PRIMARY KEY (`timetable_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `timetable`
--

LOCK TABLES `timetable` WRITE;
/*!40000 ALTER TABLE `timetable` DISABLE KEYS */;
INSERT INTO `timetable` VALUES (1,1,1,1,1,'sandeep','2016-08-02 00:00:00');
/*!40000 ALTER TABLE `timetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usergroup`
--

DROP TABLE IF EXISTS `usergroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usergroup` (
  `usergroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `group_id` int(11) NOT NULL,
  `fromuser_id` int(11) NOT NULL,
  `touser_id` int(11) NOT NULL,
  PRIMARY KEY (`usergroup_id`),
  KEY `group_idFK_idx` (`group_id`),
  CONSTRAINT `group_id` FOREIGN KEY (`group_id`) REFERENCES `group` (`group_id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Mapping User to Group. Each group will have a creator that is userid';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usergroup`
--

LOCK TABLES `usergroup` WRITE;
/*!40000 ALTER TABLE `usergroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `usergroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userinfo`
--

DROP TABLE IF EXISTS `userinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userinfo` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(100) DEFAULT NULL,
  `user_email` varchar(100) DEFAULT NULL,
  `user_password` varchar(200) DEFAULT NULL,
  `user_isactive` tinyint(1) DEFAULT NULL,
  `user_locked` tinyint(1) DEFAULT NULL,
  `user_failedattempt` int(11) DEFAULT NULL,
  `user_lockedtilldate` datetime DEFAULT NULL,
  `user_type` int(2) DEFAULT NULL,
  `user_crdate` datetime DEFAULT NULL,
  `user_crby` int(11) DEFAULT NULL,
  `user_upddate` datetime DEFAULT NULL,
  `user_updby` int(11) DEFAULT NULL,
  `user_alternatemail` varchar(100) DEFAULT NULL,
  `pwdchange_oldpwd` varchar(200) DEFAULT NULL,
  `pwdchange_newpwd` varchar(200) DEFAULT NULL,
  `pwdchange_redate` datetime DEFAULT NULL,
  `pwdchange_upddate` datetime DEFAULT NULL,
  `pwdchange_guid` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `uniqueguid_id_UNIQUE` (`pwdchange_guid`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userinfo`
--

LOCK TABLES `userinfo` WRITE;
/*!40000 ALTER TABLE `userinfo` DISABLE KEYS */;
INSERT INTO `userinfo` VALUES (3,'stu_harirocking','harirocking@gmail.com','testT@2345',1,0,1,'2016-08-02 00:00:00',1,'2016-08-02 00:00:00',1,'2016-08-02 00:00:00',1,'harirocking@gmail.com','testT@234','testT@2345','2016-09-02 12:44:51','2016-09-02 13:20:19','cbe5f617-d290-4ff4-b87e-d93c9d129188'),(4,'stu_sandeep','sandeep@gmail.com','qsIT@123',1,0,0,NULL,1,'2016-08-02 00:00:00',1,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL),(5,'stu_harish','hari@gmail.com','qsIT@123',1,0,0,NULL,1,'2016-08-02 00:00:00',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,'stu_suhas','suhas@gmail.com','qsIT@123',1,0,0,NULL,1,'2016-08-02 00:00:00',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,'stu_saikrishna','saikrish498@gmail.com','qsIT@123',1,0,0,NULL,1,'2016-08-02 00:00:00',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,'par_narayanappa','narayanappa@gmail.com','qsIT@123',1,0,0,NULL,2,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,'par_lakshmi','lakshmi@gmail.com','qsIT@123',1,0,0,NULL,2,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,'par_jhon','jhon@gmail.com','qsIT@123',1,0,0,NULL,2,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,'tec_girish','girish@gmail.com','qsIT@123',1,0,0,NULL,3,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,'tec_suresh','suresh@gmail.com','qsIT@123',1,0,0,NULL,3,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,'tec_atish','atish@gmail.com','qsIT@123',1,0,0,NULL,3,'2016-08-02 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,'ins_admin_The Valley School','reva@gmail.com','qsit@123',1,0,0,NULL,4,'2016-11-15 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,'ins_admin_Indus International School','bms@gmail.com','qsit@123',1,0,0,NULL,4,'2016-11-15 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,'ins_admin_Mallya Aditi International School','newhorizan@gmail.com','qsit@123',1,0,0,NULL,4,'2016-11-15 00:00:00',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `userinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userpersonalinfo`
--

DROP TABLE IF EXISTS `userpersonalinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userpersonalinfo` (
  `userper_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `userper_dob` date DEFAULT NULL,
  `userper_gender` int(11) DEFAULT NULL,
  `userper_countryid` int(11) DEFAULT NULL,
  `userper_stateid` int(11) DEFAULT NULL,
  `userper_cityid` int(11) DEFAULT NULL,
  `userper_favoiritesubjects` varchar(200) DEFAULT NULL,
  `userper_sports` varchar(200) DEFAULT NULL,
  `userper_hobbies` varchar(200) DEFAULT NULL,
  `userper_personalities` varchar(200) DEFAULT NULL,
  `userper_books` varchar(200) DEFAULT NULL,
  `userper_movies` varchar(200) DEFAULT NULL,
  `userper_mobile` varchar(15) DEFAULT NULL,
  `userper_alternatemobile` varchar(15) DEFAULT NULL,
  `userper_profile_pic` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`userper_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userpersonalinfo`
--

LOCK TABLES `userpersonalinfo` WRITE;
/*!40000 ALTER TABLE `userpersonalinfo` DISABLE KEYS */;
INSERT INTO `userpersonalinfo` VALUES (1,3,'2001-08-02',1,81,17,1,'Science','FootBall','Reading Book','test_personalities','C Programming','test_movies','9738798652','8738798651','Pic_stu_harirocking'),(2,4,'2001-08-02',1,81,17,3,'Math','VallyBall','Listing Song','test_personalities','Android Programming','test_movies','2738698320','5738798658','Pic_stu_sandeep'),(3,5,'1916-08-02',1,81,17,1,'Computer','FootBall','Watching TV','test_personalities','Java Programming','test_movies','7738798652','5738798655','Pic_stu_harish'),(4,6,'2001-08-02',1,81,17,7,'Math','Badminton','Listing Song','test_personalities','PHP','test_movies','8738798658','7738798654','Pic_stu_suhas'),(5,7,'1916-08-02',1,81,17,1,'Computer','cricket','Reading Book','test_personalities','C Programming','test_movies','8738798654','6738798653','Pic_stu_saikrishna'),(6,8,'2001-08-02',2,81,17,1,'Science','cricket','Listing Song','test_personalities','Android Programming','test_movies','2738698320','9738798652','Pic_par_narayanappa'),(7,9,'2001-08-02',1,81,17,5,'Computer','Badminton','Reading Book','test_personalities','ASP','test_movies','7738798652','8738798655','Pic_par_lakshmi'),(8,10,'2016-08-02',1,81,17,5,'Science','cricket','Listing Song','test_personalities','C Programming','test_movies','6738698328','6738798658','Pic_par_jhon'),(9,11,'2001-08-02',1,81,17,3,'Computer','VallyBall','Reading Book','test_personalities','FoxPro','test_movies','1738798658','8738798657','Pic_tec_girish'),(10,12,'2001-08-02',1,81,17,2,'Science','Badminton','Listing Song','test_personalities','Android Programming','test_movies','2738798655','9738798652','par_jhon'),(11,13,'2001-08-02',1,81,17,3,'Computer','cricket','Listing Song','test_personalities','C++ Programming','test_movies','9738698325','7738798652','Pic_tec_girish'),(12,14,'2001-08-02',1,81,17,1,'Science','cricket','Reading Book','test_personalities','Python programming','test_movies','7738798652','9738798652','Pic_tec_suresh'),(13,15,'2001-08-02',1,81,17,1,'Computer','Badminton','Reading Book','test_personalities','C Programming','test_movies','2738698320','9738798652','Pic_tec_atish');
/*!40000 ALTER TABLE `userpersonalinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-17 16:43:55
