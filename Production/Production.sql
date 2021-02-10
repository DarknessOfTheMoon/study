CREATE DATABASE [production]

USE [production]

CREATE TABLE[product](
	
	[IDproduct]					INT IDENTITY(1, 1),
	[NameProduct]				NVARCHAR(30)																										NOT NULL,
	[IsTypicalID]				INT	CONSTRAINT FK_product_IsTypicalID_Typical_IDtypical FOREIGN KEY REFERENCES [Typical]([IDtypical])				NOT NULL,
	[Note]						NVARCHAR(30)																										NOT NULL,
	[Manufacturing—ompany]		INT	CONSTRAINT FK_product_Manufacturing—ompany_Company_IDcompany	FOREIGN KEY REFERENCES [Company]([IDcompany])	NOT NULL,
	[MaterialID]				INT	CONSTRAINT FK_product_MaterialID_Material_IDMaterial FOREIGN KEY REFERENCES [Material]([IDMaterial])			NOT NULL,
	[Picture]					IMAGE,

	CONSTRAINT PK_product_IDproduct PRIMARY KEY([IDproduct])
)
GO

CREATE TABLE[Company](

	[IDcompany]					INT IDENTITY(1,1),
	[NameCompany]				NVARCHAR(30)			NOT NULL,
	[AddressCompany]			NVARCHAR(30)			NOT NULL,
	[NumberCompany]				INT						NOT NULL,

	CONSTRAINT PK_Company_IDcompany PRIMARY KEY([IDcompany])

)
GO

CREATE TABLE[Material](

	[IDMaterial]				INT IDENTITY(1,1),
	[NameMaterial]				NVARCHAR(30)			NOT NULL,
	[TypeMaterial]				NVARCHAR(30)			NOT NULL,
	[MaterialUnit]				INT						NOT NULL,
	  
	CONSTRAINT PK_Material_IDMaterial PRIMARY KEY([IDMaterial])
)
GO

CREATE TABLE[Typical](
	
	[IDtypical]					INT IDENTITY(1, 1),
	[TITLE]						NVARCHAR(30)			NOT NULL,
	CONSTRAINT PK_Typical_IDtypical PRIMARY KEY([IDtypical])

)
GO


CREATE TABLE[SignIn](

	[ID]		INT IDENTITY(1,1),
	[Login]		NVARCHAR(30)			NOT NULL,
	[Password]	NVARCHAR(30)			NOT NULL,
	[IDrole]	NCHAR(1)	CONSTRAINT FK_SignIn_ID_Role_roleID FOREIGN KEY REFERENCES [Role]([roleID])			NOT NULL,
	CONSTRAINT PK_SignIn_ID PRIMARY KEY ([ID])

)
GO

CREATE TABLE [Role](

	[roleID]	NCHAR(1),
	[TITLE]		NVARCHAR(30)			NOT NULL,
	CONSTRAINT PK_Role_ID PRIMARY KEY([roleID])

)
GO