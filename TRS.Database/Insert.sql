USE TRS_DB;

GO

SET IDENTITY_INSERT tblUser ON;
INSERT INTO tblUser (Id, FirstName, LastName, [Login], [PasswordHash], [Disabled])
	VALUES
		(1, 'Yura', 'Skolozdra', 'yurask', 'e46d54dc7e7b52067bf34306697094b0', 0),
		(2, 'George', 'Loki','loki', '7369780dde9330cb2204792e0096a655',0),
        (3, 'Jesse', 'Tate', 'jtate', 'e9077df1a7e9f04298b7f18f1b3690af',0),
		(4, 'Ray', 'Johns', 'rjohns', 'dd66fe2f88738d2e8c3bb6347c4c6fdb', 0),
		(5, 'Danny', 'Mur', 'dannymur', '8812d205f0621883321d6a750fa8eef2', 0)
SET IDENTITY_INSERT tblUser OFF;

GO

SET IDENTITY_INSERT tblLocation ON;
INSERT INTO tblLocation (Id, Name) VALUES
	(1, 'Hall'),
	(2, 'Bar'),
	(3, 'Terrace') 
SET IDENTITY_INSERT tblLocation OFF;

GO

SET IDENTITY_INSERT tblTable ON;
INSERT INTO tblTable (Id, Rate, CountOfSeats, LocationId) VALUES 
	(1, 120, 8, 1),
	(2, 120, 8, 1),
	(3, 120, 8, 1),
	(4, 110, 8, 1),
	(5, 110, 6, 1),
	(6, 110, 6, 1),
	(7, 100, 4, 1),
	(8, 100, 4, 1),
	(9, 100, 2, 1),
	(10, 90, 2, 1),
	(11, 90, 2, 1),
	(12, 70, 1, 2),
	(13, 70, 1, 2),
	(14, 70, 1, 2),
	(15, 70, 1, 2),
	(16, 100, 4, 3),
	(17, 100, 4, 3),
	(18, 80, 2, 3),
	(19, 80, 2, 3),
	(20, 80, 2, 3)
SET IDENTITY_INSERT tblTable OFF;

GO

SET IDENTITY_INSERT tblCustomer ON;
INSERT INTO tblCustomer (Id, FirstName, LastName, Phone) VALUES 
	(1, 'Yura', 'Skolozdra', '099-777-33-11'),
	(2, 'Ostap', 'Melnuk', '091-368-77-14'),
	(3, 'Roman', 'Girnak', '091-689-41-15'),
	(4, 'Anriy', 'Soleman', '099-168-33-16'),
	(5, 'Vasiliy', 'Beniko', '099-724-15-25'),
	(6, 'Sergiy', 'Vyshna', '091-163-13-16'),
	(7, 'Dmitriy','Koshelko', '091-987-76-65'),
	(8, 'Mike', 'Fishman', '099-123-34-45'),
	(9, 'Jesse','Brown', '065-432-54-65'),
	(10, 'James', 'Yonger', '065-135-24-36')
SET IDENTITY_INSERT tblCustomer OFF;

GO


SET IDENTITY_INSERT tblReservation ON;
INSERT INTO tblReservation (Id, TableId, CustomerId, DateIn, DateOut, [Status], Cost, UserId)
VALUES 
(1, 1, 1, '2016-03-24 16:00:00', '2016-03-24 17:00:00', 1, 240, 1),
(2, 2, 2, '2016-03-25 15:00:00', '2016-03-25 16:00:00', 1, 240, 1),
(3, 3, 3, '2016-03-25 15:00:00', '2016-03-25 16:00:00', 1, 240, 1),
(4, 4, 4, '2016-03-24 16:00:00', '2016-03-24 17:00:00', 1, 220, 1),
(5, 5, 5, '2016-03-18 19:00:00', '2016-03-18 20:00:00', 1, 220, 1),
(6, 6, 6, '2016-03-27 19:00:00', '2016-03-27 20:00:00', 1, 220, 1),
(7, 7, 7, '2016-03-27 19:00:00', '2016-03-27 20:00:00', 1, 200, 1),
(8, 8, 8, '2016-03-27 19:00:00', '2016-03-27 20:00:00', 2, 200, 1),
(9, 9, 9, '2016-03-27 19:00:00', '2016-03-27 20:00:00', 2, 220, 1),
(10, 10, 10, '2016-03-27 20:00:00', '2016-03-27 21:30:00', 2, 270, 1)
SET IDENTITY_INSERT tblReservation OFF;

GO