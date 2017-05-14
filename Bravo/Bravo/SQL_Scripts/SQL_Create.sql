CREATE DATABASE Bravo;
GO

CREATE TABLE Hersteller
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Lieferanten
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(max),
	PLZ varchar(5),
	Ort varchar(45),
	Strasse varchar(max),
	Telefon varchar(20),
	Mobil varchar(20),
	Fax varchar(20),
	EMail varchar(max)
);
GO

CREATE TABLE Raum
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Beschreibung varchar(45),
	Notiz varchar(max)	
);
GO

CREATE TABLE Komponenten
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Beschreibung varchar(max),
	Hersteller_ID int FOREIGN KEY REFERENCES Hersteller(ID),
	Gewaehrleistung_Monate INT,
	Art_ID int FOREIGN KEY REFERENCES Komponentenarten(ID),
	Lieferant_ID int FOREIGN KEY REFERENCES Lieferanten(ID),
	Einkaufsdatum date,
	Kaufbeleg Binary,
	Raum_ID int FOREIGN KEY REFERENCES Raum(ID),
	Notiz varchar(max)
);
GO

CREATE TABLE Komponenten_Attribute
(
	Komponente_ID int FOREIGN KEY REFERENCES Komponenten(ID),
	Attribute_ID int FOREIGN KEY REFERENCES Komponentenattribute(ID),
	Hersteller_ID int FOREIGN KEY REFERENCES Hersteller(ID),
	Beschreibung varchar(max) 
);
GO

CREATE TABLE Komponentenarten
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Komponentenattribute
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Komponentenart_Attribute_Vorgabe
(
	Art_ID int FOREIGN KEY REFERENCES Komponentenarten(ID),
	Attribute_ID int FOREIGN KEY REFERENCES Komponentenattribute(ID)
);