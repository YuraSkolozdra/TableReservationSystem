USE TRS_DB

GO

CREATE PROC sp_GetUserByLogin
	@login VARCHAR(50),
	@passwordHash VARCHAR(50)
AS
BEGIN
	SELECT 
		Id, 
		FirstName, 
		LastName, 
		[Login],		 
		[Disabled] 
	FROM tblUser
	WHERE [Login] = @login AND [PasswordHash] = @passwordHash AND [Disabled] <> 1;
END;

GO

CREATE PROC sp_GetReservationsByDate
	@reservationDate DATETIME,
	@reservationStatus int
AS
BEGIN
	SELECT
		res.Id,
		tab.Id as TableId,
		tab.Rate,
		tab.CountOfSeats,
		loc.Id as LocationId,
		loc.Name as LocationName,
		cust.Id as CustomerId,
		cust.FirstName as FirstName,
		cust.LastName as LastName,
		cust.Phone as Phone,
		res.DateIn,
		res.DateOut,
		res.[Status],
		res.Cost,
		res.UserId
	FROM tblReservation res
	JOIN tblTable tab
	ON res.Id = tab.Id
	JOIN tblCustomer cust
	ON res.CustomerId = cust.Id
	JOIN tblLocation loc
	ON tab.LocationId = loc.Id
	WHERE (DATEDIFF(day, res.dateIn, @reservationDate) = 0) AND res.[Status] = @reservationStatus;		
END;

GO



CREATE PROC sp_CancelReservationById
	@reservationId INT,
	@userId INT
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM tblReservation res 
		WHERE res.Id = @reservationId)
			BEGIN
				RAISERROR('Reservation with such id doesnt exist', 11, 238);
			END
	UPDATE tblReservation
		SET [Status] = 2,
		     UserId = @userId
		WHERE Id = @reservationId;
	RETURN 0;
END;

GO


CREATE PROC sp_GetTablesByDateAndSeats
	@dateIn DATETIME,
	@dateOut DATETIME,
	@countOfSeats INT
AS
BEGIN
	SELECT
		DISTINCT tab.Id,
		tab.Rate,
		tab.CountOfSeats,
		loc.Id AS LocationId,
		loc.Name AS LocationName
	FROM tblTable tab
	JOIN tblLocation loc
	ON tab.LocationId = loc.Id
	LEFT OUTER JOIN tblReservation res
	ON tab.Id = res.TableId
	WHERE (((res.[Status] <> 1) OR (@dateIn > res.DateOut OR @dateOut < res.DateIn)) 
				OR res.Id IS NULL) AND (@countOfSeats <= tab.CountOfSeats)
	--ORDER BY tab.CountOfSeats, tab.Rate;
END;

GO

CREATE PROCEDURE sp_ReserveTable
	@firstName NVARCHAR(50),
	@lastName NVARCHAR(50),
	@phone VARCHAR(30),
	@dateIn DATETIME,
	@dateOut DATETIME,
	@tableId INT,
	@userId INT,
	@reservationId INT OUT
AS
BEGIN
	BEGIN TRAN
		DECLARE @customerId INT;
		SELECT @customerId = cust.Id FROM tblCustomer cust 
			WHERE (cust.Phone = @phone);

		IF (@customerId IS NULL)
		BEGIN
			INSERT INTO tblCustomer(FirstName, LastName, Phone) VALUES(@firstName, @lastName, @phone);
			SET @customerId = @@IDENTITY;
		END;

		IF (@dateIn > @dateOut)
		BEGIN
			ROLLBACK TRAN;
			THROW 60000 ,'Reservation start date and time must be greater than finish date and time!', 1;
		END;

		IF EXISTS(SELECT 1 FROM tblReservation res 
			WHERE (res.TableId = @tableId) AND (res.[Status] = 1) AND
					NOT ((@dateIn < res.DateIn AND @dateOut < res.DateIn) OR
						(@dateIn > res.DateOut AND @dateOut > res.DateOut)))
			BEGIN
				ROLLBACK TRAN;
				THROW 60000, 'This table is already rent for such date', 1;
			END
	
		DECLARE @cost NUMERIC(18, 4);
		DECLARE @rate NUMERIC(18, 4);
		DECLARE @minutes INT;

		SELECT @rate = tab.Rate FROM tblTable tab WHERE tab.Id = @tableId;
		SELECT @minutes = DATEDIFF(minute, @dateIn, @dateOut);
		SET @cost = (@rate / 30) * @minutes;

		INSERT INTO tblReservation (TableId, CustomerId, DateIn, DateOut, [Status], Cost, UserId)
		VALUES (@tableId, @customerId, @dateIn, @dateOut, 1, @cost, @userId);
	
		SET @reservationId = @@IDENTITY;
	COMMIT TRAN;
END;

GO

CREATE PROCEDURE sp_GetCostOfReservation
					@tableId INT,
					@dateIn DATETIME,
					@dateOut DATETIME,
					@cost NUMERIC(18, 4) OUT
AS
BEGIN
	DECLARE @rate NUMERIC(18, 4);
	DECLARE @minutes INT;

	SELECT @rate = tab.Rate FROM tblTable tab WHERE tab.Id = @tableId;
	SELECT @minutes = DATEDIFF(minute, @dateIn, @dateOut);
	SET @cost = (@rate / 30) * @minutes;		
END;

GO