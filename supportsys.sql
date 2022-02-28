/*
SQLyog Community v12.09 (64 bit)
MySQL - 5.6.45-log : Database - supportsys
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`supportsys` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `supportsys`;

/*Table structure for table `abm` */

DROP TABLE IF EXISTS `abm`;

CREATE TABLE `abm` (
  `abm_id` int(10) NOT NULL AUTO_INCREMENT,
  `abmbusiness` decimal(4,2) NOT NULL,
  `abmprofserv` decimal(4,2) NOT NULL,
  PRIMARY KEY (`abm_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `abm` */

/*Table structure for table `acadresults` */

DROP TABLE IF EXISTS `acadresults`;

CREATE TABLE `acadresults` (
  `resultid` int(10) NOT NULL AUTO_INCREMENT,
  `stemres` decimal(4,2) NOT NULL,
  `abmres` decimal(4,2) NOT NULL,
  `hummsres` decimal(4,2) NOT NULL,
  `gasres` decimal(4,2) NOT NULL,
  PRIMARY KEY (`resultid`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `acadresults` */

insert  into `acadresults`(`resultid`,`stemres`,`abmres`,`hummsres`,`gasres`) values (1,'43.55','90.34','90.33','55.32');

/*Table structure for table `agri` */

DROP TABLE IF EXISTS `agri`;

CREATE TABLE `agri` (
  `agri_id` int(10) NOT NULL AUTO_INCREMENT,
  `agriaqua` decimal(4,2) NOT NULL,
  `agribusiness` decimal(4,2) NOT NULL,
  `agriengr` decimal(4,2) NOT NULL,
  PRIMARY KEY (`agri_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `agri` */

/*Table structure for table `artsdesigntrack` */

DROP TABLE IF EXISTS `artsdesigntrack`;

CREATE TABLE `artsdesigntrack` (
  `arts_id` int(10) NOT NULL AUTO_INCREMENT,
  `artsmedia` decimal(4,2) NOT NULL,
  `artsprofserv` decimal(4,2) NOT NULL,
  `arts` decimal(4,2) NOT NULL,
  `artsfashion` decimal(4,2) NOT NULL,
  PRIMARY KEY (`arts_id`),
  KEY `id` (`arts_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `artsdesigntrack` */

insert  into `artsdesigntrack`(`arts_id`,`artsmedia`,`artsprofserv`,`arts`,`artsfashion`) values (1,'56.45','54.12','65.43','54.23');

/*Table structure for table `artsresult` */

DROP TABLE IF EXISTS `artsresult`;

CREATE TABLE `artsresult` (
  `resultid` int(10) NOT NULL,
  `artsress` decimal(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `artsresult` */

/*Table structure for table `gas` */

DROP TABLE IF EXISTS `gas`;

CREATE TABLE `gas` (
  `gas_id` int(10) NOT NULL AUTO_INCREMENT,
  `gasprofserv` decimal(4,2) NOT NULL,
  `gasfinance` decimal(4,2) NOT NULL,
  `gasperserv` decimal(4,2) NOT NULL,
  `gascomserv` decimal(4,2) NOT NULL,
  `gaspirit` decimal(4,2) NOT NULL,
  PRIMARY KEY (`gas_id`),
  KEY `id` (`gas_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `gas` */

/*Table structure for table `homecon` */

DROP TABLE IF EXISTS `homecon`;

CREATE TABLE `homecon` (
  `hecon_id` int(10) NOT NULL AUTO_INCREMENT,
  `heconfashion` decimal(4,2) NOT NULL,
  `heconcomserv` decimal(4,2) NOT NULL,
  `heconperserv` decimal(4,2) NOT NULL,
  PRIMARY KEY (`hecon_id`),
  KEY `id` (`hecon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `homecon` */

/*Table structure for table `humms` */

DROP TABLE IF EXISTS `humms`;

CREATE TABLE `humms` (
  `humms_id` int(10) NOT NULL AUTO_INCREMENT,
  `hummsmedia` decimal(4,2) NOT NULL,
  `hummscommu` decimal(4,2) NOT NULL,
  `hummsarts` decimal(4,2) NOT NULL,
  `hummsfash` decimal(4,2) NOT NULL,
  `hummsspirit` decimal(4,2) NOT NULL,
  `hummsmilitary` decimal(4,2) NOT NULL,
  `hummsperserv` decimal(4,2) NOT NULL,
  PRIMARY KEY (`humms_id`),
  KEY `id` (`humms_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `humms` */

/*Table structure for table `ict` */

DROP TABLE IF EXISTS `ict`;

CREATE TABLE `ict` (
  `ict_id` int(10) NOT NULL AUTO_INCREMENT,
  `ictengr` decimal(4,2) NOT NULL,
  `ictcomputer` decimal(4,2) NOT NULL,
  `ictbusiness` decimal(4,2) NOT NULL,
  PRIMARY KEY (`ict_id`),
  KEY `id` (`ict_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `ict` */

/*Table structure for table `industarts` */

DROP TABLE IF EXISTS `industarts`;

CREATE TABLE `industarts` (
  `ia_id` int(10) NOT NULL AUTO_INCREMENT,
  `iaarchi` decimal(4,2) NOT NULL,
  `iaengr` decimal(4,2) NOT NULL,
  `iafashion` decimal(4,2) NOT NULL,
  PRIMARY KEY (`ia_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `industarts` */

/*Table structure for table `sportsresult` */

DROP TABLE IF EXISTS `sportsresult`;

CREATE TABLE `sportsresult` (
  `resultid` int(10) NOT NULL,
  `sportsres` decimal(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sportsresult` */

/*Table structure for table `sportstrack` */

DROP TABLE IF EXISTS `sportstrack`;

CREATE TABLE `sportstrack` (
  `sports_id` int(10) NOT NULL AUTO_INCREMENT,
  `sporsmili` decimal(4,2) NOT NULL,
  `sportscomserv` double(4,2) NOT NULL,
  `sportsperserv` decimal(4,2) NOT NULL,
  PRIMARY KEY (`sports_id`),
  KEY `id` (`sports_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sportstrack` */

/*Table structure for table `stem` */

DROP TABLE IF EXISTS `stem`;

CREATE TABLE `stem` (
  `stem_id` int(10) NOT NULL AUTO_INCREMENT,
  `stemscience` decimal(4,2) NOT NULL,
  `stemengr` decimal(4,2) NOT NULL,
  `stemarchi` decimal(4,2) NOT NULL,
  `stemtech` decimal(4,2) NOT NULL,
  `stemnatsci` decimal(4,2) NOT NULL,
  PRIMARY KEY (`stem_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

/*Data for the table `stem` */

/*Table structure for table `tvlresults` */

DROP TABLE IF EXISTS `tvlresults`;

CREATE TABLE `tvlresults` (
  `resultid` int(10) NOT NULL,
  `agrires` decimal(4,2) NOT NULL,
  `hecores` decimal(4,2) NOT NULL,
  `ictres` decimal(4,2) NOT NULL,
  `iares` decimal(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tvlresults` */

insert  into `tvlresults`(`resultid`,`agrires`,`hecores`,`ictres`,`iares`) values (1,'54.66','90.32','88.34','78.43');

/*Table structure for table `userinfo` */

DROP TABLE IF EXISTS `userinfo`;

CREATE TABLE `userinfo` (
  `userid` int(15) NOT NULL AUTO_INCREMENT,
  `uname` varchar(20) NOT NULL,
  `pword` varchar(20) NOT NULL,
  `email` varchar(20) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `phonenum` varchar(15) NOT NULL,
  PRIMARY KEY (`userid`),
  KEY `id` (`userid`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `userinfo` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
