DROP DATABASE if exists HotelManagmentSystemDP;
CREATE DATABASE HotelManagmentSystemDP;
use HotelManagmentSystemDP;
CREATE TABLE `users` (
  `SSN` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `address` varchar(20) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `mobileNumber` varchar(20) NOT NULL,
  `birthOfDate` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `isAdmin` tinyint(1) NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`SSN`)
) ;

CREATE TABLE `guests` (
  `SSN` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `mobileNumber` varchar(15) NOT NULL,
  `birthOfDate` date NOT NULL,
  `nationality` varchar(20) NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`SSN`)
) ;


CREATE TABLE `roomtypes` (
  `roomType` varchar(10) NOT NULL,
  `pricePerDay` double NOT NULL,
  PRIMARY KEY (`roomType`)
) ;
CREATE TABLE `rooms` (
  `id` int auto_increment NOT NULL,
  `roomType` varchar(20) NOT NULL,
  `isReserved` tinyint(1) default false,
  `created_at` timestamp  DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_roomType` (`roomType`),
  CONSTRAINT `fk_roomType` FOREIGN KEY (`roomType`) REFERENCES `roomtypes` (`roomType`)
) ;
CREATE TABLE `reservations` (
  `id` int auto_increment NOT NULL,
  `SSN` varchar(50) NOT NULL,
  `roomId` int NOT NULL,
  `checkin` date NOT NULL,
  `checkout` date ,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_guestReservation` (`SSN`),
  KEY `fk_room` (`roomId`),
  CONSTRAINT `fk_guestReservation` FOREIGN KEY (`SSN`) REFERENCES `guests` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_room` FOREIGN KEY (`roomId`) REFERENCES `rooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ;

CREATE TABLE `payments` (
  `SSN` varchar(50) NOT NULL,
  `reservationId` int NOT NULL,
  `totalPrice` double NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`SSN`,`reservationId`),
  KEY `fk_reservation` (`reservationId`),
  CONSTRAINT `fk_guestPayment` FOREIGN KEY (`SSN`) REFERENCES `guests` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_reservation` FOREIGN KEY (`reservationId`) REFERENCES `reservations` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ;

insert into users(`SSN`, `firstName` ,`lastName`,  `address`, `gender` , `mobileNumber` ,`birthOfDate` ,`email`,  `username` ,  `password` , `isAdmin`) values ('300010926','Mahmoud','Hamdy','Sohag Gohaina' ,'male','201012776232','2000-01-09','mahmoudh.morsy','ma7moud7amdy','123456',true);
-- ------------------------------

DELIMITER //
CREATE PROCEDURE GetTotalPrice(in reservationId int,out totalPrice double)
BEGIN

 select @checkInDate := Reservations.checkin ,@checkOutDate := Reservations.checkout ,@roomId := Reservations.roomId  from Reservations where Reservations.id=reservationId ;
 select @roomType:=rooms.roomType from rooms   where rooms.id=@roomId;
 select @roomPrice:=RoomTypes.pricePerDay from RoomTypes  where @roomType=RoomTypes.roomType;
 SET totalPrice=(DATEDIFF(@checkOutDate,@checkInDate)+1)*@roomPrice;
 select totalPrice;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER `reserveRoom` AFTER INSERT ON `reservations` FOR EACH ROW begin
  update rooms set rooms.isReserved=true where rooms.id=new.roomId;
  end//
DELIMITER ;


DELIMITER //
CREATE TRIGGER `checkoutRoom` AFTER UPDATE ON `reservations` 
FOR EACH ROW 
begin if(old.checkout is null and new.checkout is not null) THEN  
 update rooms set rooms.isReserved=false where rooms.id=new.roomId;
 END IF;
 end//
 
DELIMITER ;


DELIMITER //

CREATE PROCEDURE EditGuest(GID varchar(50),fName varchar(50),lName varchar(50),Phone varchar(50),country varchar(50) ,addres varchar(50),timeToString_ varchar(50), gend varchar(6))
BEGIN
UPDATE Guests SET SSN = GID, firstName = fName, lastName = lName, mobileNumber = Phone, Nationality = country, address = addres, birthOfDate = timeToString_, gender = gend where SSN = GID;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE RemoveGuest(IN GuestId VARCHAR(15))
BEGIN
DELETE FROM Guests
WHERE SSN = GuestId;
END //
DELIMITER ;