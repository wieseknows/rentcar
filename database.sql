-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: avtoprokat
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
-- Table structure for table `adres`
--

DROP TABLE IF EXISTS `adres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `adres` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `strana` varchar(45) NOT NULL,
  `gorod` varchar(45) NOT NULL,
  `ulica` varchar(45) NOT NULL,
  `dom` int(11) NOT NULL,
  `kvartira` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adres`
--

LOCK TABLES `adres` WRITE;
/*!40000 ALTER TABLE `adres` DISABLE KEYS */;
INSERT INTO `adres` VALUES (1,'Албания','Тирана','Пушкина',23,566),(2,'Пакистан','Исламабад','Айзирисо',66,6),(3,'Россия','Тюмень','Пушкина',165,35),(4,'Беларусь','Гомель','Пушкина',36,96),(5,'Украина','Киев','Зразумивча',89,55),(6,'Беларусь','Гомель','Петруся Бровки',21,32),(7,'Беларусь','Гомель','Техническая',3,66),(8,'Беларусь','Минск','Пушкина',5,80),(9,'Россия','Астрахань','Богдановича',102,80),(10,'Россия','Москва','Темирязева',12,36),(11,'Албания','Минск','Албанова',23,62);
/*!40000 ALTER TABLE `adres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avtomobil`
--

DROP TABLE IF EXISTS `avtomobil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avtomobil` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_marka` int(11) NOT NULL,
  `id_model` int(11) NOT NULL,
  `id_kuzov` int(11) NOT NULL,
  `id_strahovanie` int(11) NOT NULL,
  `moshnost` int(11) DEFAULT '0',
  `id_tehosmotr` int(11) NOT NULL,
  `id_tarif` int(11) NOT NULL,
  `nalichie` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_avto-kuzov_idx` (`id_kuzov`),
  KEY `fk_avto-model_idx` (`id_model`),
  KEY `fk_avto-strahovanie_idx` (`id_strahovanie`),
  KEY `fk_avto-tarif_idx` (`id_tarif`),
  KEY `fk_avto-tehosmotr_idx` (`id_tehosmotr`),
  KEY `fk_avto-marka_idx` (`id_marka`),
  CONSTRAINT `fk_avto-kuzov` FOREIGN KEY (`id_kuzov`) REFERENCES `kuzov` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_avto-marka` FOREIGN KEY (`id_marka`) REFERENCES `marka` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_avto-model` FOREIGN KEY (`id_model`) REFERENCES `model` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_avto-strahovanie` FOREIGN KEY (`id_strahovanie`) REFERENCES `strahovanie` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_avto-tarif` FOREIGN KEY (`id_tarif`) REFERENCES `tarif` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_avto-tehosmotr` FOREIGN KEY (`id_tehosmotr`) REFERENCES `tehosmotr` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avtomobil`
--

LOCK TABLES `avtomobil` WRITE;
/*!40000 ALTER TABLE `avtomobil` DISABLE KEYS */;
INSERT INTO `avtomobil` VALUES (1,5,11,1,1,236,1,1,'В наличии'),(2,7,4,1,2,600,4,4,'В наличии'),(4,2,3,1,4,85,8,3,'Занят'),(5,10,15,1,5,96,7,8,'Занят'),(6,10,12,1,6,260,5,2,'В наличии'),(12,11,16,5,19,99,17,15,'В наличии'),(13,1,17,2,20,230,18,20,'В наличии');
/*!40000 ALTER TABLE `avtomobil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dolzhnost`
--

DROP TABLE IF EXISTS `dolzhnost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dolzhnost` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazvanie` varchar(45) DEFAULT NULL,
  `zarplata` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dolzhnost`
--

LOCK TABLES `dolzhnost` WRITE;
/*!40000 ALTER TABLE `dolzhnost` DISABLE KEYS */;
INSERT INTO `dolzhnost` VALUES (1,'Менеджер',790),(2,'Администратор',1600),(3,'Директор',1900);
/*!40000 ALTER TABLE `dolzhnost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klient`
--

DROP TABLE IF EXISTS `klient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `familiya` varchar(45) DEFAULT NULL,
  `imya` varchar(45) DEFAULT NULL,
  `otchestvo` varchar(45) DEFAULT NULL,
  `id_voditelskie_prava` int(11) DEFAULT NULL,
  `id_pasport` int(11) DEFAULT NULL,
  `id_medic_spravka` int(11) DEFAULT NULL,
  `id_adres` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_voditelskie_prava_idx` (`id_voditelskie_prava`),
  KEY `fk_klient-adres_idx` (`id_adres`),
  KEY `fk_klient-med_spravka_idx` (`id_medic_spravka`),
  KEY `fk_klient-pasport_idx` (`id_pasport`),
  CONSTRAINT `fk_klient-adres` FOREIGN KEY (`id_adres`) REFERENCES `adres` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_klient-med_spravka` FOREIGN KEY (`id_medic_spravka`) REFERENCES `medic_spravka` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_klient-pasport` FOREIGN KEY (`id_pasport`) REFERENCES `pasport` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_klient-voditelskie_prava` FOREIGN KEY (`id_voditelskie_prava`) REFERENCES `voditelskie_prava` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klient`
--

LOCK TABLES `klient` WRITE;
/*!40000 ALTER TABLE `klient` DISABLE KEYS */;
INSERT INTO `klient` VALUES (1,'Острейко ','Николай','Анатольевич',1,1,2,1),(2,'Пьеха','Станислав','Эдитович',2,2,3,3),(3,'Дёрден','Тайлер','Джонович',3,3,9,4),(4,'Вассерман','Анатолий','Анатольевич',4,4,1,6),(5,'Стоцкая','Анастасия','Петровна',5,5,10,5),(6,'Лебедев','Артемий ','Кириллович',6,6,4,2),(7,'Самбука','Екатерина','Владимировна',7,7,8,9),(8,'Сноу','Джон','Олегович',8,8,6,7),(9,'Селизнёва','Василиса','Кирилловна',9,9,7,10),(10,'Патриарх','Кирилл','Олеговна',10,10,5,8);
/*!40000 ALTER TABLE `klient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kuzov`
--

DROP TABLE IF EXISTS `kuzov`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kuzov` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazvanie` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kuzov`
--

LOCK TABLES `kuzov` WRITE;
/*!40000 ALTER TABLE `kuzov` DISABLE KEYS */;
INSERT INTO `kuzov` VALUES (1,'Седан'),(2,'Универсал'),(3,'Кабриолет'),(5,'Минивэн'),(6,'Грузовик'),(7,'Седан'),(9,'Пикапчик');
/*!40000 ALTER TABLE `kuzov` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marka`
--

DROP TABLE IF EXISTS `marka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marka` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazvanie` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marka`
--

LOCK TABLES `marka` WRITE;
/*!40000 ALTER TABLE `marka` DISABLE KEYS */;
INSERT INTO `marka` VALUES (1,'BMW'),(2,'Nissan'),(3,'Audi'),(4,'Volkswagen'),(5,'Vaz'),(6,'Toyota'),(7,'Chevrolette'),(8,'Renault'),(9,'Mercedes'),(10,'Lamborghini'),(11,'Ford');
/*!40000 ALTER TABLE `marka` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medic_spravka`
--

DROP TABLE IF EXISTS `medic_spravka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medic_spravka` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_medic_uchrezhdenie` int(11) DEFAULT NULL,
  `zdorovie` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_spravka-uchrezhdenie_idx` (`id_medic_uchrezhdenie`),
  CONSTRAINT `fk_spravka-uchrezhdenie` FOREIGN KEY (`id_medic_uchrezhdenie`) REFERENCES `medic_uchrezhdenie` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medic_spravka`
--

LOCK TABLES `medic_spravka` WRITE;
/*!40000 ALTER TABLE `medic_spravka` DISABLE KEYS */;
INSERT INTO `medic_spravka` VALUES (1,1,'Без ограничений'),(2,2,'Без ограничений'),(3,1,'Без ограничений'),(4,1,'Без ограничений'),(5,1,'Без ограничений'),(6,2,'Без ограничений'),(7,5,'Без ограничений'),(8,3,'Без ограничений'),(9,3,'Без ограничений'),(10,3,'Без ограничений'),(11,7,'Вождение без ограничений'),(12,8,'Без ограничений');
/*!40000 ALTER TABLE `medic_spravka` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medic_uchrezhdenie`
--

DROP TABLE IF EXISTS `medic_uchrezhdenie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medic_uchrezhdenie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazvanie` varchar(45) DEFAULT NULL,
  `adres` varchar(45) DEFAULT NULL,
  `tip_uchrezhdeniya` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medic_uchrezhdenie`
--

LOCK TABLES `medic_uchrezhdenie` WRITE;
/*!40000 ALTER TABLE `medic_uchrezhdenie` DISABLE KEYS */;
INSERT INTO `medic_uchrezhdenie` VALUES (1,'Городская №5','Ломоносова 5','Поликлинника'),(2,'Районная №2','Темирязева 12','Поликлинника'),(3,'Городская №6','Пушкина 123','Поликлинника'),(4,'Городская №8','Петровская 9','Больница'),(5,'Районная №1','Октябрьская 43','Поликлинника'),(6,'Городская №5','Анисимова 656','Больница'),(7,'Городская №8','Ломоносова 5','Больница'),(8,'Городская №5','hfghfgh','Больница');
/*!40000 ALTER TABLE `medic_uchrezhdenie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `model`
--

DROP TABLE IF EXISTS `model`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `model` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazvanie` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `model`
--

LOCK TABLES `model` WRITE;
/*!40000 ALTER TABLE `model` DISABLE KEYS */;
INSERT INTO `model` VALUES (1,'C-Class W204'),(2,'A6'),(3,'GT-R'),(4,'Camaro SS'),(5,'S8'),(6,'5 Series E39'),(7,'Camry'),(8,'Golf GTI'),(9,'S-Class W222'),(10,'M5 E60'),(11,'2110'),(12,'Aventador'),(13,'Impala'),(14,'Logan'),(15,'Gallardo'),(16,'Galaxy'),(17,'520i');
/*!40000 ALTER TABLE `model` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pasport`
--

DROP TABLE IF EXISTS `pasport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pasport` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `seriya` varchar(45) NOT NULL DEFAULT 'ХХ',
  `nomer` varchar(45) NOT NULL DEFAULT '0000000',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pasport`
--

LOCK TABLES `pasport` WRITE;
/*!40000 ALTER TABLE `pasport` DISABLE KEYS */;
INSERT INTO `pasport` VALUES (1,'КВ','1659932'),(2,'МТ','2896675'),(3,'МТ','2163226'),(4,'МТ','6985632'),(5,'КВ','3259774'),(6,'МТ','1264489'),(7,'КВ','2567485'),(8,'МТ','3269985'),(9,'КВ','3257896'),(10,'КВ','1857756'),(11,'КВ','6595652'),(12,'КВ','dfgdfgd');
/*!40000 ALTER TABLE `pasport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sotrudnik`
--

DROP TABLE IF EXISTS `sotrudnik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sotrudnik` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imya` varchar(45) DEFAULT NULL,
  `familiya` varchar(45) DEFAULT NULL,
  `otchestvo` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `parol` varchar(45) DEFAULT NULL,
  `id_dolzhnost` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_sotrudnik-dolzhnost_idx` (`id_dolzhnost`),
  CONSTRAINT `fk_sotrudnik-dolzhnost` FOREIGN KEY (`id_dolzhnost`) REFERENCES `dolzhnost` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sotrudnik`
--

LOCK TABLES `sotrudnik` WRITE;
/*!40000 ALTER TABLE `sotrudnik` DISABLE KEYS */;
INSERT INTO `sotrudnik` VALUES (1,'Петр','Чайка','Адамович','petr','user',1),(2,'Владимир','Иванов','Петрович','vladimir','user',3),(3,'Анастасия','Петрова','Дмитриевна','nastya','admin',2),(4,'Ладислав','Синицын','Андреевич','ladislav','user',1),(5,'Артемий','Сухарь','Олегович','artemy','admin',2),(6,'Анатолий','Саховский','Артурович','anatoliy','user',1),(7,'Виктория','Тычина','Владимировна','vika','admin',1),(8,'Алина','Соколова','Романовна','alina','admin',2),(9,'Никита','Примерный','Олегович','nikita','user',1),(10,'Николай','Наумов','Арменович','nikolai','user',1),(12,'Мусаси','Гегард','Валентинович','wiese','admin',1);
/*!40000 ALTER TABLE `sotrudnik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `strahovanie`
--

DROP TABLE IF EXISTS `strahovanie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `strahovanie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kompaniya` varchar(45) DEFAULT NULL,
  `srok` int(11) DEFAULT NULL,
  `summa` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `strahovanie`
--

LOCK TABLES `strahovanie` WRITE;
/*!40000 ALTER TABLE `strahovanie` DISABLE KEYS */;
INSERT INTO `strahovanie` VALUES (1,'Белгосстрах',36,5000),(2,'Промтрансинвест',60,3100),(3,'Белгосстрах',36,6200),(4,'Промтрансинвест',24,5000),(5,'Белнефтестрах',36,4500),(6,'Белгосстрах',60,2660),(7,'Белнефтестрах',60,8000),(8,'Белгосстрах',60,5000),(10,'Белнефтестрах',36,5000),(13,'Промтрансинвест',15,100),(19,'Белнефтестрах',25,600),(20,'Белгосстрах',23,60);
/*!40000 ALTER TABLE `strahovanie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarif`
--

DROP TABLE IF EXISTS `tarif`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarif` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cena_za_sutki` float DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarif`
--

LOCK TABLES `tarif` WRITE;
/*!40000 ALTER TABLE `tarif` DISABLE KEYS */;
INSERT INTO `tarif` VALUES (1,20),(2,12),(3,20),(4,12.5),(5,20),(6,32),(7,20),(8,50),(9,20),(11,21),(12,8),(13,7),(14,30),(15,15),(16,5),(17,60),(18,52.75),(19,26),(20,16);
/*!40000 ALTER TABLE `tarif` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tehosmotr`
--

DROP TABLE IF EXISTS `tehosmotr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tehosmotr` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` year(4) DEFAULT NULL,
  `ispravnost` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tehosmotr`
--

LOCK TABLES `tehosmotr` WRITE;
/*!40000 ALTER TABLE `tehosmotr` DISABLE KEYS */;
INSERT INTO `tehosmotr` VALUES (1,2015,'Исправен'),(2,2015,'Исправен'),(3,2016,'Исправен'),(4,2015,'Исправен'),(5,2016,'Исправен'),(6,2015,'Исправен'),(7,2016,'Исправен'),(8,2016,'Не исправен'),(9,2015,'Исправен'),(10,2016,'Не исправен'),(11,2016,'Исправен'),(12,2016,'Исправен'),(13,2011,'Исправен'),(14,2009,'Не исправен'),(15,2005,'Не исправен'),(16,2014,'Не исправен'),(17,2013,'Исправен'),(18,2004,'Не исправен');
/*!40000 ALTER TABLE `tehosmotr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voditelskie_prava`
--

DROP TABLE IF EXISTS `voditelskie_prava`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voditelskie_prava` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` date DEFAULT NULL,
  `kategoriya` char(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=224 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voditelskie_prava`
--

LOCK TABLES `voditelskie_prava` WRITE;
/*!40000 ALTER TABLE `voditelskie_prava` DISABLE KEYS */;
INSERT INTO `voditelskie_prava` VALUES (1,'2003-12-21','C'),(2,'2006-07-31','A'),(3,'2014-02-12','B'),(4,'2012-10-10','B'),(5,'2013-11-14','B'),(6,'2008-08-17','B'),(7,'2012-12-12','B'),(8,'1995-10-15','C'),(9,'2012-06-19','B'),(10,'2007-08-26','A'),(221,'2016-11-09','C'),(222,'2016-11-10','D'),(223,'2016-11-17','A');
/*!40000 ALTER TABLE `voditelskie_prava` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zakaz`
--

DROP TABLE IF EXISTS `zakaz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zakaz` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_klient` int(11) DEFAULT NULL,
  `id_avtomobil` int(11) DEFAULT NULL,
  `id_sotrudnik` int(11) DEFAULT NULL,
  `data` date NOT NULL,
  `srok` int(11) DEFAULT NULL,
  `stoimost` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_zakaz-sotrudnik_idx` (`id_sotrudnik`),
  KEY `fk_zakaz-avto_idx` (`id_avtomobil`),
  KEY `fk_zakaz-klient_idx` (`id_klient`),
  CONSTRAINT `fk_zakaz-avto` FOREIGN KEY (`id_avtomobil`) REFERENCES `avtomobil` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_zakaz-klient` FOREIGN KEY (`id_klient`) REFERENCES `klient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_zakaz-sotrudnik` FOREIGN KEY (`id_sotrudnik`) REFERENCES `sotrudnik` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=194 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zakaz`
--

LOCK TABLES `zakaz` WRITE;
/*!40000 ALTER TABLE `zakaz` DISABLE KEYS */;
INSERT INTO `zakaz` VALUES (2,3,5,4,'2016-01-02',4,NULL),(3,1,4,2,'1998-01-02',4,NULL),(6,6,6,3,'1998-01-02',7,NULL),(7,7,1,3,'1998-01-02',4,NULL),(186,5,5,2,'2016-12-22',9,450),(187,8,4,2,'2016-11-16',6,120),(188,7,4,2,'2016-12-09',5,100),(189,8,6,2,'2016-12-09',5,60),(190,4,2,2,'2016-12-09',1,12),(191,1,4,2,'2016-12-09',5,100),(192,3,4,2,'2016-12-09',4,80),(193,4,4,2,'2016-12-09',5,100);
/*!40000 ALTER TABLE `zakaz` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-16 16:45:30
