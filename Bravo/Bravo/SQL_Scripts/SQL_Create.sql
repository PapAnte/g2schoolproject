CREATE DATABASE Bravo;
GO

USE Bravo

CREATE TABLE Hersteller
(
	ID int IDENTITY(1,1) CONSTRAINT HerstellerID PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Lieferant
(
	ID int IDENTITY(1,1) CONSTRAINT LieferantID PRIMARY KEY,
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
	ID int IDENTITY(1,1) CONSTRAINT RaumID PRIMARY KEY,
	Beschreibung varchar(45),
	Notiz varchar(max)	
);
GO

CREATE TABLE Komponentenattribute
(
	ID int IDENTITY(1,1) CONSTRAINT KomponentenattributeID PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Komponentenart
(
	ID int IDENTITY(1,1) CONSTRAINT KomponentenartID PRIMARY KEY,
	Beschreibung varchar(max)
);
GO

CREATE TABLE Komponente
(
	ID int IDENTITY(1,1) CONSTRAINT KomponenteID PRIMARY KEY,
	Beschreibung varchar(max),
	Hersteller_ID int CONSTRAINT FK_KomponenteHersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Gewaehrleistung_Monate INT,
	Art_ID int CONSTRAINT FK_KomponenteKomponentenart FOREIGN KEY REFERENCES Komponentenart(ID),
	Lieferant_ID int CONSTRAINT FK_Komponentelieferant FOREIGN KEY REFERENCES Lieferant(ID),
	Einkaufsdatum date,
	Kaufbeleg Binary,
	Raum_ID int CONSTRAINT FK_KomponenteRaum FOREIGN KEY REFERENCES Raum(ID),
	Notiz varchar(max)
);
GO

CREATE TABLE Komponenten_Attribut
(
	Komponente_ID int CONSTRAINT FK_KomponentenAttribut_Komponente FOREIGN KEY REFERENCES Komponente(ID),
	Attribute_ID int CONSTRAINT FK_KomponentenAttribut_Komponentenattribute FOREIGN KEY REFERENCES Komponentenattribute(ID),
	Hersteller_ID int CONSTRAINT FK_KomponentenAttribut_Hersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Beschreibung varchar(max) 
);
GO

CREATE TABLE Komponentenart_Attribute_Vorgabe
(
	Art_ID int CONSTRAINT FK_KomponentenAttributVorgabe_Komponentenart FOREIGN KEY REFERENCES Komponentenart(ID),
	Attribute_ID int CONSTRAINT FK_KomponentenAttribut_Komponentenattribute2 FOREIGN KEY REFERENCES Komponentenattribute(ID)
);
GO

CREATE TABLE Rechtevorlage
(
	ID int IDENTITY(1,1) CONSTRAINT RechevorlageID PRIMARY KEY,
	Beschreibung varchar(max),
	Lesen bit,
	Bearbeiten bit,
	Erstellen bit,
	Entfernen bit
);