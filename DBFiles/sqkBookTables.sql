Use Cinema
GO

IF(Exists(SELECT 1 FROM sys.tables WHERE name = 'CinemaBook'))  DROP TABLE CinemaBook
GO
IF(Exists(SELECT 1 FROM sys.tables WHERE name = 'CinemaSession'))  DROP TABLE CinemaSession
GO
IF(Exists(SELECT 1 FROM sys.tables WHERE name = 'CinemaPlaces'))  DROP TABLE CinemaPlaces
GO
IF(Exists(SELECT 1 FROM sys.tables WHERE name = 'CinemaHall')) DROP TABLE CinemaHall
GO
IF(Exists(SELECT 1 FROM sys.tables WHERE name = 'CinemaList'))  DROP TABLE CinemaList
GO

GO

CREATE TABLE CinemaList
(
	[ID] int PRIMARY KEY Identity(1,1) NOT NULL,
	[Name] nvarchar(100) NOT NULL,
	[Description] nvarchar(500) NULL,
	[Address] nvarchar(500) NULL
)

GO
CREATE TABLE CinemaHall
(
	[ID] int PRIMARY KEY identity(1,1) NOT NULL,
	[CinemaID] int REFERENCES CinemaList(ID) NOT NULL,
	[HallName] nvarchar(50) NULL,
	[HallNumber] int NOT NULL default(1)
)

GO
CREATE TABLE CinemaPlaces
(
	[ID] int PRIMARY KEY identity(1,1) NOT NULL,
	[HallID] int REFERENCES CinemaList(ID) NOT NULL,
	[Row] int NOT NULL,
	[Col] int NOT NULL,
	[Zone] int NULL default(NULL),
	[ZoneName] nvarchar(100) NULL default(NULL)
)

GO
CREATE TABLE CinemaSession
(
	[ID] int PRIMARY KEY identity(1,1) NOT NULL,
	[CinemaID] int REFERENCES CinemaList(ID) NOT NULL,
	[CinemaHallID] int REFERENCES CinemaHall(ID) NOT NULL,
	[Date] DATE NOT NULL,
	[Time] Time NOT NULL
)

GO
CREATE TABLE CinemaBook
(
	[ID] int PRIMARY KEY identity(1,1) NOT NULL,
	[PlaceID] int REFERENCES CinemaPlaces(ID) NOT NULL,
	[SessionID] int REFERENCES CinemaSession(ID) NOT NULL,
	[Price] decimal(18,9) NOT NULL,
	[Booked] bit NOT NULL default(0),
	[Reserved] bit NOT NULL default(0)
)