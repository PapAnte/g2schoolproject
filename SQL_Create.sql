CREATE DATABASE Bravo;
GO

USE Bravo

CREATE TABLE Hersteller
(
	ID int IDENTITY(1,1) CONSTRAINT HerstellerID PRIMARY KEY,
	Bezeichnung varchar(45)
);
GO

CREATE TABLE Lieferant
(
	ID int IDENTITY(1,1) CONSTRAINT LieferantID PRIMARY KEY,
	Name varchar(45),
	PLZ varchar(5),
	Ort varchar(45),
	Strasse varchar(45),
	Telefon varchar(20),
	Mobil varchar(20),
	Fax varchar(20),
	EMail varchar(80)
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
	Bezeichnung varchar(45),
	[Version] varchar(45),
	Lizenz_Benutzerumfang int,
	Lizenz_Schlüssel varchar(45),
	Hersteller_ID int,
	Lieferanten_ID int,
	Einkaufsdatum date,
	Einkaufsbeleg binary,
	Notiz varchar(1024)
);
GO

CREATE TABLE Software_in_Raum
(
	Software_ID int CONSTRAINT FK_SoftwareraumSoftware FOREIGN KEY REFERENCES Software(ID),
	Raum_ID int CONSTRAINT FK_SoftwareraumRaum FOREIGN KEY REFERENCES Raum(ID)
);
GO

CREATE TABLE Geraetkomponente
(
	ID int IDENTITY(1,1) CONSTRAINT GeraetkomponenteID PRIMARY KEY,
	Bezeichnung varchar(45)
);
GO

CREATE TABLE Geraetart
(
	ID int IDENTITY(1,1) CONSTRAINT GeraetartID PRIMARY KEY,
	Bezeichnung varchar(45)
);
GO

CREATE TABLE Geraet
(
	ID int IDENTITY(1,1) CONSTRAINT GeraetID PRIMARY KEY,
	Bezeichnung varchar(45),
	Hersteller_ID int CONSTRAINT FK_GeraetHersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Gewaehrleistung_Monate int,
	Art_ID int CONSTRAINT FK_GeraetGeraetart FOREIGN KEY REFERENCES Geraetart(ID),
	Lieferant_ID int CONSTRAINT FK_Geraetlieferant FOREIGN KEY REFERENCES Lieferant(ID),
	Einkaufsdatum date,
	Einkaufbeleg binary,
	Raum_ID int CONSTRAINT FK_GeraetRaum FOREIGN KEY REFERENCES Raum(ID),
	Notiz varchar(1024)
);
GO

CREATE TABLE Geraetkomponente_Information
(
	Komponente_ID int CONSTRAINT FK_GeraetkomponenteinformationGeraet FOREIGN KEY REFERENCES Geraet(ID),
	Attribute_ID int CONSTRAINT FK_GeraetkomponenteinformationGeraetattribute FOREIGN KEY REFERENCES Geraetkomponente(ID),
	Hersteller_ID int CONSTRAINT FK_GeraetkomponenteinformationHersteller FOREIGN KEY REFERENCES Hersteller(ID),
	Bezeichnung varchar(100) 
);
GO

CREATE TABLE Geraetart_Komponenten_Vorgabe
(
	Art_ID int CONSTRAINT FK_GeraetnkomponentenvorgabeGeraetart FOREIGN KEY REFERENCES Geraetart(ID),
	Attribut_ID int CONSTRAINT FK_GeraetkomponentenGeraetattribute FOREIGN KEY REFERENCES Geraetkomponente(ID)
);
GO

CREATE TABLE Rechtevorlage
(
	ID int IDENTITY(1,1) CONSTRAINT RechevorlageID PRIMARY KEY,
	Bezeichnung varchar(45),
	Lesen bit,
	Bearbeiten bit,
	Erstellen bit,
	Entfernen bit
);
GO

CREATE TABLE Rechtegruppe
(
	ID int IDENTITY(1,1) CONSTRAINT RechtegruppeID PRIMARY KEY,
	Bezeichnung varchar(45),
	Benutzerverwaltung_Vollzugriff bit,
	Tickets int,
	Ausstattung int
);
GO

CREATE TABLE WebBenutzer
(
	Nutzername varchar(80) CONSTRAINT WebBenutzerID PRIMARY KEY,
	Passwort varchar(80),
	Rechtegruppe_ID int CONSTRAINT FK_WebbenutzerRechtegruppe FOREIGN KEY REFERENCES Rechtegruppe(ID),
	Name varchar(80),
	Anrede varchar(15),
	Titel varchar(15),
	Geburtsdatum date,
	EMail varchar(80),
	Erstellungsdatum date
);
GO

CREATE TABLE Ticket
(
	ID int IDENTITY(1,1) CONSTRAINT TicketID PRIMARY KEY,
	Bezeichnung varchar(80),
	Notiz varchar(1024),
	Ersteller varchar(80) CONSTRAINT FK_TicketWebbenutzerErsteller FOREIGN KEY REFERENCES WebBenutzer(Nutzername),
	DatumEingang date,
	Bearbeiter varchar(80) CONSTRAINT FK_TicketWebbenutzerBearbeiter FOREIGN KEY REFERENCES WebBenutzer(Nutzername),
	AbgeschlossenDatum date	
);
GO

INSERT INTO Rechtevorlage
	(Bezeichnung, Lesen, Bearbeiten, Erstellen, Entfernen)
VALUES
	('Reader', 1, 0, 0, 0),
	('Editor', 1, 1, 0, 0),
	('ExtEditor', 1, 1, 1, 0),
	('Super', 1, 1, 1, 1);
GO

INSERT INTO Rechtegruppe
	(Bezeichnung, Benutzerverwaltung_Vollzugriff, Tickets, Austattung)
VALUES
	('Root', 1, 4, 4),
	('Admin', 1, 3, 3),
	('IT-Azubi', 0, 3, 3),
	('Lehrer', 0, 1, 1),
	('Verwaltung', 0, 1, 1);
GO

INSERT INTO WebBenutzer
	(Nutzername, Passwort, Rechtegruppe_ID, Name, Anrede, Titel, Geburtsdatum, EMail, Erstellungsdatum)
VALUES
	('Admin', 'admin', 1, 'Root-Administrator', '', '', '', '', CONVERT(date, GetDate()));