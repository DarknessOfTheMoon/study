CREATE DATABASE [airport]

USE[airport]

CREATE TABLE [passengers](

	[id]			int identity(0, 1),
	[surName]		nvarchar(15)																												not null,
	[lastName]		nvarchar(15)																												not null,
	[MaddleName]	nvarchar(15),
	[genderID]		nchar(1)	constraint fk_passengers_genderID_Gender_IDgender foreign key references Gender([IDgender])						not null,
	[passportID]	int																															not null,
	[citizenshipID]	int constraint fk_passengers_citizenshipID_citizenship_IDcitizenship foreign key references citizenship([IDcitizenship])	not null,
	[idFlight]		 nchar(1) constraint fk_passengers_idFlight_flight_FlifhtId foreign key references flight([FlifhtId])								not null,
	constraint pk_passengers_id	primary key([id])
		
)
GO

CREATE TABLE[flight](

	[FlifhtId]			nchar(1),
	[distance]			int						not null,
	[departurePoint]	int constraint fk_flight_departurePoint_Point_IDpoint foreign key references Point([IDpoint]) not null,
	[pointOfArrival]	int constraint fk_flight_pointOfArrival_Point_IDpoint foreign key references Point([IDpoint]) not null,
	[departureDate]		date					not null, 
	[arrivalDate]		date					not null,
	[TicketsSold]		int						not null,
	[IDplane]			int	constraint fk_flight_Idplane_plane_planeID foreign key references plane([planeID])	not null,
	constraint pk_flight_id primary key([FlifhtId]) 

)
GO

CREATE TABLE [plane](

	[planeID]			int identity(0, 1),
	[name]				nvarchar(30)			not null,
	[numberOfPlaces]	int						not null,
	[flightSpeed]		int						not null,
	constraint pk_plane_id	primary key([planeID])
		
)
GO

CREATE TABLE[Gender](
	
	[IDgender]	nchar(1),
	[name]		nvarchar(10)	not null,
	constraint pk_Gender_IDgender primary key([IDgender])

)
GO

CREATE TABLE[citizenship](

	[IDcitizenship]		int identity(0, 1),
	[title]		nvarchar(30)			not null,
	constraint pk_citizenship_id primary key([IDcitizenship])
	
)
GO

create table [Point](
		
	[IDpoint]				int identity(0,1),
	[titlDeparturee]		nvarchar(30)		not null,
	[titleArrival]			nvarchar(30)			not null,

	constraint pk_Point_IDpoint	primary key ([IDpoint])

)
GO


SELECT * FROM [passengers]