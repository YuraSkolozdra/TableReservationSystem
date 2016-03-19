USE TRS;

GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_GetUserByLogin' AND type = 'P')
BEGIN
DROP PROCEDURE sp_GetUserByLogin 
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