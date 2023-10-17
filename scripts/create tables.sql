------- CREATE NEW DB ------------------------------------------------------------------
CREATE DATABASE gae

------- CREATE NEW TABLES --------------------------------------------------------------
Use [gae]
Go 

CREATE TABLE FacilityCategory (
	facilityCategoryId		int IDENTITY(1,1) PRIMARY KEY,
    facilityCategoryName	nvarchar(45) NOT NULL
);

CREATE TABLE Equipment (
	equipmentId				int IDENTITY(1,1) PRIMARY KEY,
    equipmentName			nvarchar(45) NOT NULL,
    equipmentDescription	nvarchar(45) NOT NULL
);

CREATE TABLE Facility (
	facilityId				int IDENTITY(1,1) PRIMARY KEY,
    facilityName			nvarchar(45) NOT NULL,
    facilityCapacity		nvarchar(45) NOT NULL, 
    facilityLocation		nvarchar(70) NOT NULL,
    facilityCategoryIdFK   	int NOT NULL,
    FOREIGN KEY (facilityCategoryIdFK) REFERENCES FacilityCategory(facilityCategoryId) ON DELETE CASCADE
);

CREATE TABLE FacilityHasEquipment(
    facilityIdFK          	int NOT NULL,
    equipmentIdFK   		int NOT NULL,
    FOREIGN KEY (facilityIdFK) REFERENCES Facility(facilityId) ON DELETE CASCADE,
    FOREIGN KEY (equipmentIdFK) REFERENCES Equipment(equipmentId) ON DELETE CASCADE
);

CREATE TABLE Reservation (
	reservationId			int IDENTITY(1,1) PRIMARY KEY,
    reservationDate			date NOT NULL,
	reservationStartTime	time NOT NULL,
    reservationEndTime		time NOT NULL,
    reservationStatus	 	tinyint NOT NULL,
    asociationId			nvarchar(70) NOT NULL,
    delegateId				nvarchar(70),
    participants			int NOT NULL
);

CREATE TABLE ReservationHasFacility(
    facilityIdFK          	int NOT NULL,
    reservationIdFK   		int NOT NULL,
    FOREIGN KEY (facilityIdFK) REFERENCES Facility(facilityId) ON DELETE CASCADE,
    FOREIGN KEY (reservationIdFK) REFERENCES Reservation(reservationId) ON DELETE CASCADE
);

