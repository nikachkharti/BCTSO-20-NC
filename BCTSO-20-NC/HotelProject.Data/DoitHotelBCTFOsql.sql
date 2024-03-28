CREATE TABLE Hotels
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Rating FLOAT NOT NULL,
	Country NVARCHAR(50) NOT NULL,
	City NVARCHAR(50) NOT NULL,
	PhyisicalAddress NVARCHAR(50) NOT NULL
)

INSERT INTO Hotels([Name],Rating,Country,City,PhyisicalAddress)
VALUES
(N'პირველი სასტუმრო',9.3,N'საქართველო',N'თბილისი',N'რუსთაველის 4'),
(N'მეორე სასტუმრო',8.0,N'საქართველო',N'ბათუმი',N'გამსახურიდას 12'),
(N'მესამე სასტუმრო',7.7,N'საქართველო',N'თბილისი',N'პეკინის 13')


CREATE TABLE Managers
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	HotelId INT UNIQUE FOREIGN KEY  REFERENCES Hotels(Id)
)

INSERT INTO Managers(FirstName,LastName,HotelId)
VALUES
(N'გიორგი',N'გიორგაძე',1),
(N'თამაზი',N'გოდერძიშვილი',2),
(N'გიორგი',N'გუჯარელიძე',3)


--CREATE PROCEDURE sp_AddHotel
--@name NVARCHAR(50),
--@rating FLOAT,
--@country NVARCHAR(50),
--@city NVARCHAR(50),
--@phyisicalAddress NVARCHAR(50)
--AS
--BEGIN
--	INSERT INTO Hotels([Name],Rating,Country,City,PhyisicalAddress)
--	VALUES
--	(@name,@rating,@country,@city,@phyisicalAddress)
--END


--CREATE PROCEDURE sp_UpdateHotel
--@name NVARCHAR(50),
--@rating FLOAT,
--@country NVARCHAR(50),
--@city NVARCHAR(50),
--@phyisicalAddress NVARCHAR(50),
--@hotelId INT
--AS
--BEGIN
--	UPDATE Hotels
--	SET
--		[Name] = @name,
--		Rating = @rating,
--		Country = @country,
--		City = @city,
--		PhyisicalAddress = @phyisicalAddress
--	WHERE Id = @hotelId
--END


--CREATE PROCEDURE sp_DeleteHotel
--@hotelId INT
--AS
--BEGIN
--	DELETE FROM Hotels WHERE Id = @hotelId
--END