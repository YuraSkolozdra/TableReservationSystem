USE TRS_DB;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetUserByLogin' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetUserByLogin; 
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetReservationsByDate' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetReservationsByDate; 
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetAllReservationsByCustomerPhone' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetAllReservationsByCustomerPhone; 
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_CancelReservationById' AND type = 'P')
BEGIN
DROP PROCEDURE sp_CancelReservationById; 
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetTablesByDateAndSeats' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetTablesByDateAndSeats;
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetCostOfReservation' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetCostOfReservation;
END;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_ReserveTable' AND type = 'P')
BEGIN
DROP PROCEDURE sp_ReserveTable 
END;

GO

IF EXISTS(select * from sysobjects where name='tblReservation' and type='U')
BEGIN
DROP TABLE tblReservation;
END;

GO

IF EXISTS(select * from sysobjects where name='tblUser' and type='U')
BEGIN
DROP TABLE tblUser;
END;

GO

IF EXISTS(select * from sysobjects where name='tblCustomer' and type='U')
BEGIN
DROP TABLE tblCustomer
END;

GO

IF EXISTS(select * from sysobjects where name='tblTable' and type='U')
BEGIN
DROP TABLE tblTable
END;

GO

IF EXISTS(select * from sysobjects where name='tblLocation' and type='U')
BEGIN
DROP TABLE tblLocation;
END;

GO