CREATE DATABASE [ChainOfStores]

USE[ChainOfStores]

CREATE  TABLE[SUPPLY](

	[ID]					INT IDENTITY(1, 1),
	[storeID]				INT CONSTRAINT FK_SUPPLY_storeID_STORE_IDstore FOREIGN KEY REFERENCES [STORE]([IDstore])				NOT NULL,
	[providerID]			INT CONSTRAINT FK_SUPPLY_providerID_PROVIDER_IDprovide FOREIGN KEY REFERENCES [PROVIDER]([IDprovide])	NOT NULL,
	CONSTRAINT PK_SUPPLY_ID	PRIMARY KEY([ID])

)
GO

CREATE TABLE[PROVIDER](
	
	[IDprovide]				INT	IDENTITY(1, 1),
	[SurName]				NVARCHAR(30)																							NOT NULL,
	[LastName]				NVARCHAR(30)																							NOT NULL,
	[MiddleName]			NVARCHAR(30)																							NOT NULL,
	[NumberProvider]		INT																										NOT NULL,
	[DeliveryCost]			INT																										NOT NULL,
	CONSTRAINT PK_PROVIDER_IDprovide PRIMARY KEY([IDprovide])

)
GO

CREATE TABLE [STORE](

	[IDstore]				INT IDENTITY(1, 1),
	[NameStore]				NVARCHAR(30)																							NOT NULL,
	[Address]				NVARCHAR(30)																							NOT NULL,
	[NumberStore]			INT																										NOT NULL,
	[AuthorizedCapital]		NVARCHAR(30)																							NOT NULL,
	[ownerID]				INT CONSTRAINT FK_STORE_ownerID_OWNER_IDowner	FOREIGN KEY REFERENCES [OWNER]([IDowner])				NOT NULL,
	[IDprofile]				INT	CONSTRAINT FK_STORE_IDprofile_PROFILE_profileID	FOREIGN  KEY REFERENCES [PROFILE]([profileID])		NOT NULL,
	CONSTRAINT PK_STORE_ID PRIMARY KEY([IDstore])

)
GO


CREATE TABLE[OWNER](

	[IDowner]				INT IDENTITY(1, 1),
	[SurName]				NVARCHAR(30)																							NOT NULL,
	[LastName]				NVARCHAR(30)																							NOT NULL,
	[MiddleName]			NVARCHAR(30)																							NOT NULL,
	[NumberOwner]			INT																										NOT NULL,
	[DepositAamount]		INT																										NOT NULL,
	[NumberRegistration]	INT																										NOT NULL,
	[DateRregistration]		DATE																									NOT NULL,
	CONSTRAINT PK_OWNER_IDowner PRIMARY KEY([IDowner])

)
GO

CREATE TABLE[PROFILE](

	[profileID]				INT IDENTITY(1, 1),
	[TITLE]					NVARCHAR(30)																							NOT NULL,
	CONSTRAINT	FK_PROFILE_profileID PRIMARY KEY([profileID])

)
GO