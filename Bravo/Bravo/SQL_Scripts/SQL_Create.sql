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
	Bezeichnung varchar(45),
	Notiz varchar(max)	
);
GO

CREATE TABLE Software
(
	ID int IDENTITY(1,1) CONSTRAINT SoftwareID PRIMARY KEY,
	Bezeichnung varchar(max),
	[Version] varchar(45),
	Lizenz_Benutzerumfang int,
	Lizenz_Schlüssel varchar(45),
	Hersteller_ID int,
	Lieferanten_ID int,
	Einkaufsdatum date,
	Einkaufsbeleg binary,
	Notiz varchar(max)
);
GO

CREATE TABLE Software_in_Raum
(
	Software_ID int CONSTRAINT FK_SoftwareraumSoftware FOREIGN KEY REFERENCES Software(ID),
	Raum_ID int CONSTRAINT FK_SoftwareraumRaum FOREIGN KEY REFERENCES Raum(ID)
);
GO

CREATE TABLE Geraetattribut
(
	ID int IDENTITY(1,1) CONSTRAINT GeraetattributeID PRIMARY KEY,
	Bezeichnung varchar(max)
);
GO

CREATE TABLE Geraetart
(
	ID int IDENTITY(1,1) CONSTRAINT GeraetartID PRIMARY KEY,
	Bezeichnung varchar(max)
);
GO

CREATE TABLE Geraet
(
	ID int IDENTITY(1,1) CONSTRAINT KomponenteID PRIMARY KEY,
	Bezeichnung varchar(max),
	Hersteller_ID int CONSTRAINT FK_GeraetHersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Gewaehrleistung_Monate INT,
	Art_ID int CONSTRAINT FK_GeraetGeraetart FOREIGN KEY REFERENCES Geraetart(ID),
	Lieferant_ID int CONSTRAINT FK_Geraetlieferant FOREIGN KEY REFERENCES Lieferant(ID),
	Einkaufsdatum date,
	Einkaufbeleg Binary,
	Raum_ID int CONSTRAINT FK_GeraetRaum FOREIGN KEY REFERENCES Raum(ID),
	Notiz varchar(max)
);
GO

CREATE TABLE Geraet_Attributinformation
(
	Komponente_ID int CONSTRAINT FK_GeraetattributinformationGeraet FOREIGN KEY REFERENCES Geraet(ID),
	Attribute_ID int CONSTRAINT FK_GeraetattributinformationGeraetattribute FOREIGN KEY REFERENCES Geraetattribut(ID),
	Hersteller_ID int CONSTRAINT FK_GeraetattributinformationHersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Bezeichnung varchar(max) 
);
GO

CREATE TABLE Geraetart_Attribute_Vorgabe
(
	Art_ID int CONSTRAINT FK_GeraetnattributvorgabeGeraetart FOREIGN KEY REFERENCES Geraetart(ID),
	Attribute_ID int CONSTRAINT FK_GeraetattributGeraetattribute FOREIGN KEY REFERENCES Geraetattribut(ID)
);
GO

CREATE TABLE Rechtevorlage
(
	ID int IDENTITY(1,1) CONSTRAINT RechevorlageID PRIMARY KEY,
	Bezeichnung varchar(max),
	Lesen bit,
	Bearbeiten bit,
	Erstellen bit,
	Entfernen bit
);

CREATE TABLE Rechtegruppe
(
	ID int IDENTITY(1,1) CONSTRAINT RechtegruppeID PRIMARY KEY,
	Bezeichnung varchar(max),
	Benutzerverwaltung_Vollzugriff bit,
	Ticket int,
	Komponenten int
);

CREATE TABLE WebBenutzer
(
	Nutzername varchar(80) CONSTRAINT WebBenutzerID PRIMARY KEY,
	Passwort varchar(80),
	Rechtegruppe_ID int CONSTRAINT FK_WebbenutzerRechtegruppe FOREIGN KEY REFERENCES Rechtegruppe(ID),
	Name varchar(80),
	Anrede varchar(15),
	Titel varchar(15),
	Geburtstag date,
	EMail varchar(160),
	Erstellungsdatum date
);

CREATE TABLE Ticket
(
	ID int IDENTITY(1,1) CONSTRAINT TicketID PRIMARY KEY,
	Bezeichnung varchar(max),
	Notiz varchar(max),
	Ersteller varchar(80) CONSTRAINT FK_TicketWebbenutzerErsteller FOREIGN KEY REFERENCES WebBenutzer(Nutzername),
	DatumEingang date,
	Bearbeiter varchar(80) CONSTRAINT FK_TicketWebbenutzerBearbeiter FOREIGN KEY REFERENCES WebBenutzer(Nutzername),
	AbgeschlossenDatum date	
);