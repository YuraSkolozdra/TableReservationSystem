IF NOT EXISTS(select * from sysdatabases where name='TRS')
BEGIN
	CREATE DATABASE TRS;
END;

GO

USE TRS;

GO

IF NOT EXISTS(select * from sysobjects where name='tblUser' and type='U')
BEGIN
CREATE TABLE tblUser
(
	Id INT IDENTITY(1, 1) NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	[Login] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Disabled] BIT NOT NULL,
	CONSTRAINT PK_tblUser_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblUser_Login UNIQUE ([Login])
);
END;

GO

IF NOT EXISTS(select * from sysobjects where name='tblLocation' and type='U')
BEGIN
	CREATE TABLE tblLocation
	(
		Id INT IDENTITY(1, 1) NOT NULL,
		Name nvarchar(30) NOT NULL,
		CONSTRAINT PK_tblLocation_Id PRIMARY KEY (Id)
	);
END;

GO

IF NOT EXISTS(select * from sysobjects where name='tblTable' and type='U')
BEGIN
	CREATE TABLE tblTable
	(
		Id INT IDENTITY(1, 1) NOT NULL,
		Rate numeric(18, 4) NOT NULL,
		CountOfSeats INT NOT NULL,
		LocationId INT NOT NULL,
		CONSTRAINT PK_tblTable_Id PRIMARY KEY (Id),
		CONSTRAINT FK_tblTable_LocationId_tblLocation_Id FOREIGN KEY (LocationId) REFERENCES tblLocation(Id)  
	);
END;

GO

IF NOT EXISTS(select * from sysobjects where name='tblCustomer' and type='U')
BEGIN
	CREATE TABLE tblCustomer
	(
		Id INT IDENTITY(1, 1) NOT NULL,
		FirstName NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		Phone VARCHAR(30) UNIQUE NOT NULL,
		CONSTRAINT PK_tblCustomer_Id PRIMARY KEY (Id),
		CONSTRAINT UQ_tblCustomer_Phone UNIQUE (Phone)  
	);
END;

GO

IF NOT EXISTS(select * from sysobjects where name='tblReservation' and type='U')
BEGIN
	CREATE TABLE tblReservation
	(
		Id INT IDENTITY(1, 1) NOT NULL,
		TableId INT NOT NULL,
		CustomerId INT NOT NULL,
		DateIn datetime NOT NULL,
		DateOut datetime NOT NULL,
		[Status] int NOT NULL,
		Cost numeric(18, 4) NOT NULL,
		UserId int NOT NULL,
		CONSTRAINT PK_tblReservation_Id PRIMARY KEY (Id),
		CONSTRAINT CHK_tblReservation_Dates CHECK (DateIn < DateOut),
		CONSTRAINT FK_tblReservation_TableId_tblTable_Id FOREIGN KEY (TableId) REFERENCES tblTable(Id),
		CONSTRAINT FK_tblReservation_CustomerId_tblCustomer_Id FOREIGN KEY (CustomerId) REFERENCES tblCustomer(Id),
		CONSTRAINT FK_tblReservation_UserId_tblUser_Id FOREIGN KEY (UserId) REFERENCES tblUser(Id) 
	);
END;

GO

