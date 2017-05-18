using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bravo.ITVerwaltungDBInterface
{
	/// <summary>
	/// Statische Klasse zur Schnittstellenanbindung an die Datenbank
	/// </summary>
	public static class ITVerwaltungDatabaseMgt
	{
		public const string DB_SERVER = "";
		public const string DB_NAME = "ITVerwaltung";
		public const string DB_LOGIN_NAME = "";
		public const string DB_LOGIN_PW = "";
		public const int DB_CONN_TIMEOUT = 15;

		#region User Management
		/// <summary>
		/// Versucht einen Benutzer einzuloggen.
		/// </summary>
		/// <param name="username">Benutzername</param>6
		/// <param name="password">Benutzerpasswort</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergbebnis</returns>
		public static DBResultMessage TryLogin(string username, string password, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, das Passwort eines Web-Benutzers zu ändern.
		/// </summary>
		/// <param name="username">Benutzername</param>
		/// <param name="oldPassword">Altes Passwort</param>
		/// <param name="newPasswort">Neues Passwort</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryChangeUserPassword(string username, string oldPassword, string newPasswort, out string resultMessage)
		{
			//TODO
			resultMessage = "FUnktion nicht impelementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Überprüft, ob der Benutzer berechtigt ist, auf eine Tabelle mit einer Zugriffsmethode zuzugreifen.
		/// Achtung: Gibt Done zurück, wenn der Befehl erfolgreich ist! Ergebnis sagt nichts über Berechtigung aus!
		/// </summary>
		/// <param name="username">Benutzername</param>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="accessMethod">Zugriffsmethode</param>
		/// <param name="isAllowed">Gibt an, ob Benutzer berechtigt ist.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergbebnis</returns>
		public static DBResultMessage IsUserAllowedTo(string username, DBTableSinglePK table, DBAccessMethod accessMethod, out bool isAllowed, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			isAllowed = true;
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Überprüft, ob der Benutzer berechtigt ist, auf eine Tabelle mit einer Zugriffsmethode zuzugreifen.
		/// Achtung: Gibt Done zurück, wenn der Befehl erfolgreich ist! Ergebnis sagt nichts über Berechtigung aus!
		/// </summary>
		/// <param name="username">Benutzername</param>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="accessMethod">Zugriffsmethode</param>
		/// <param name="isAllowed">Gibt an, ob Benutzer berechtigt ist.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergbebnis</returns>
		public static DBResultMessage IsUserAllowedTo(string username, DBTableDoublePK table, DBAccessMethod accessMethod, out bool isAllowed, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			isAllowed = true;
			return DBResultMessage.Error;
		}
		#endregion

		#region Insert / Assign
		/// <summary>
		/// Versucht, Ticket in der Datenbank einzufügen
		/// </summary>
		/// <param name="user">Benutzername</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertTicket(string user, string designation, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Web-Benutzer in der Datenbank einzufügen.
		/// </summary>
		/// <param name="username">Benutzername</param>
		/// <param name="rightID">Rechtegruppe-ID</param>
		/// <param name="name">Name</param>
		/// <param name="salutation">Anrede</param>
		/// <param name="title">Titel</param>
		/// <param name="birthDate">Geburtsdatum</param>
		/// <param name="email">EMail-Adresse</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertWebUser(string username, string rightID, string name, string salutation, string title, string birthDate, string email, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Hersteller in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertManufacturer(string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Raum in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertRoom(string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Lieferant in der Datenbank einzufügen.
		/// </summary>
		/// <param name="name">Name</param>
		/// <param name="plz">Postleitzahl</param>
		/// <param name="city">Ort/Stadt</param>
		/// <param name="street">Straße & Hausnr.</param>
		/// <param name="telNo">Telefonnr</param>
		/// <param name="mobileNo">Mobilnr</param>
		/// <param name="faxNo">Faxnr</param>
		/// <param name="email">Email-Adresse</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertSupplier(string name, string plz, string city, string street, string telNo, string mobileNo, string faxNo, string email, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Software in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="version">Version</param>
		/// <param name="license_userCount">Lizenz-Benutzerumfang</param>
		/// <param name="license_key">Lizenzschlüssel</param>
		/// <param name="manufacturerID">Hersteller-ID</param>
		/// <param name="supplierID">Lieferant-ID</param>
		/// <param name="buyingDate">Einkaufsdatum</param>
		/// <param name="buyingDoc">Einkaufsbeleg (jpg/jpeg)</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertSoftware(string designation, string version, string license_userCount, string license_key, string manufacturerID, string supplierID, string buyingDate, object buyingDoc, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerät in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="manufacturerID">Hersteller-ID</param>
		/// <param name="warrantyDuration">Gewährsleistungsdauer</param>
		/// <param name="typeID">Gerätetyp-ID</param>
		/// <param name="supplierID">Lieferant-ID</param>
		/// <param name="buyingDate">Einkaufsdatum</param>
		/// <param name="buyingDoc">Einkaufsbeleg (jpg/jpeg)</param>
		/// <param name="roomID">Raum-ID</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertDevice(string designation, string manufacturerID, string warrantyDuration, string typeID, string supplierID, string buyingDate, object buyingDoc, string roomID, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerätetyp in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertDeviceType(string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerätekomponente in der Datenbank einzufügen.
		/// </summary>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertDeviceComponent(string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Vorgabe für Verknüpfung zwischen Gerätekomponente & Geräteart in der Datenbank einzufügen.
		/// </summary>
		/// <param name="typeID"></param>
		/// <param name="compID"></param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertSpecDevicecompToDevicetype(string typeID, string compID, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Verknüpfung zwischen Software und Raum in der Datenbank einzufügen.
		/// </summary>
		/// <param name="softwareID">Software-ID</param>
		/// <param name="roomID">Raum-ID</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryInsertAssignmentSoftwareToRoom(string softwareID, string roomID, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}
		#endregion

		#region GetAll
		/// <summary>
		/// Versucht, eine Auflistung der Datensätze in einer bestimmten DB-Tabelle aus der Datenbank zu erhalten.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="filterPK">Filter auf Primärschlüssel. Wenn leer erfolgt keine Filterung.</param>
		/// <param name="resultList">Ergebnis-Liste</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryGetAll(DBTableSinglePK table, string filterPK, out List<object[]> resultList, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			resultList = new List<object[]>();
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, eine Auflistung der Datensätze in einer bestimmten DB-Tabelle aus der Datenbank zu erhalten.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="filterPKOne">Filter auf ersten Primärschlüssel - wenn leer erfolgt keine Filterung.</param>
		/// <param name="filterPKTwo">Filter auf zweiten Primärschlüssel - wenn leer erfolgt keine Filterung.</param>
		/// <param name="resultList">Ergebnis-Liste</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryGetAll(DBTableDoublePK table, string filterPKOne, string filterPKTwo, out List<object[]> resultList, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			resultList = new List<object[]>();
			return DBResultMessage.Error;
		}
		#endregion

		#region GetByPK
		/// <summary>
		/// Versucht einen bestimmten Datensatz aus einer Tabelle 
		/// mit einfachem PK bestehend aus einer Spalte aus der Datenbank zu erhalten.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="primKeyValue">PK-Wert</param>
		/// <param name="resultDateset">Ergebnis-Datensatz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryGetDatesetByPK(DBTableSinglePK table, string primKeyValue, out object[] resultDateset, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			resultDateset = null;
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht einen bestimmten Datensatz aus einer Tabelle 
		/// mit zusammengesetztem PK bestehend aus zwei Spalten aus der Datenbank zu erhalten.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="primKeyValueOne">Wert des ersten Primärschlüssel-Felds</param>
		/// <param name="primKeyValueTwo">Wert des zweiten Primärschlüssel-Felds</param>
		/// <param name="resultDateset">Ergebnis-Datensatz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryGetDatesetByPK(DBTableDoublePK table, string primKeyValueOne, string primKeyValueTwo, out object[] resultDateset, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			resultDateset = null;
			return DBResultMessage.Error;
		}
		#endregion

		#region UpdateByPK
		/// <summary>
		/// Versucht, einen WebBenutzer als Bearbeiter in ein Ticket in der Datenbank zuzuweisen.
		/// </summary>
		/// <param name="ticketID">Ticket-ID</param>
		/// <param name="username">Benutzername</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TrySetEditorInTicket(string ticketID, string username, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Ticket in der Datenbank abzuschließen.
		/// </summary>
		/// <param name="id">Ticket-ID</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryFinishTicket(string id, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Notiz eines Tickets in der Datenbank zu editieren.
		/// </summary>
		/// <param name="id">Ticket-ID</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form.</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateTicketNote(string id, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Web-Benutzer in der Datenbank zu editieren.
		/// </summary>
		/// <param name="username">Benutzername</param>
		/// <param name="rightID">Rechtegruppe-ID</param>
		/// <param name="name">Name</param>
		/// <param name="salutation">Anrede</param>
		/// <param name="title">Titel</param>
		/// <param name="birthDate">Geburtsdatum</param>
		/// <param name="email">EMail-Adresse</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateWebUser(string username, string rightID, string name, string salutation, string title, string birthDate, string email, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Hersteller in der Datenbank zu editieren.
		/// </summary>
		/// <param name="manufacturerID">Hersteller-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateManufacturer(string manufacturerID, string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Raum in der Datenbank zu editieren.
		/// </summary>
		/// <param name="roomID">Raum-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateRoom(string roomID, string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Lieferant in der Datenbank zu editieren.
		/// </summary>
		/// <param name="plz">Postleitzahl</param>
		/// <param name="city">Ort/Stadt</param>
		/// <param name="street">Straße & Hausnr.</param>
		/// <param name="telNo">Telefonnr</param>
		/// <param name="mobileNo">Mobilnr</param>
		/// <param name="faxNo">Faxnr</param>
		/// <param name="email">Email-Adresse</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateSupplier(string supplierID, string name, string plz, string city, string street, string telNo, string mobileNo, string faxNo, string email, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Software in der Datenbank zu editieren.
		/// </summary>
		/// <param name="softwareID">Software-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateSoftware(string softwareID, string designation, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerät in der Datenbank zu editieren.
		/// </summary>
		/// <param name="deviceID">Geräte-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="roomID">Raum-ID</param>
		/// <param name="note">Notiz</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateDevice(string deviceID, string designation, string roomID, string note, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerätetyp in der Datenbank zu editieren.
		/// </summary>
		/// <param name="typeID">Gerätetyp-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateDeviceType(string typeID, string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, Gerätekomponente in der Datenbank zu editieren.
		/// </summary>
		/// <param name="componentID">Gerätekomponent-ID</param>
		/// <param name="designation">Bezeichnung</param>
		/// <param name="ignoreDuplicates">Kennzeichnung, ob Duplikate ignoriert werden sollen. Wenn ja, gibt es ein Duplikat-Ergebnis bei ähnlich bereits vorhandenen Bezeichnungen.</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryUpdateDeviceComponent(string componentID, string designation, bool ignoreDuplicates, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}
		#endregion

		#region DeleteByPK
		/// <summary>
		/// Versucht einen bestimmten Datensatz aus einer Tabelle 
		/// mit einfachem PK bestehend aus einer Spalte aus der Datenbank zu löschen.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="primKeyValue">PK-Wert</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryDeleteDatesetByPK(DBTableSinglePK table, string primKeyValue, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht einen bestimmten Datensatz aus einer Tabelle 
		/// mit zusammengesetztem PK bestehend aus zwei Spalten aus der Datenbank zu löschen.
		/// </summary>
		/// <param name="table">DB-Tabelle</param>
		/// <param name="primKeyValueOne">Wert des ersten Primärschlüssel-Felds</param>
		/// <param name="primKeyValueTwo">Wert des zweiten Primärschlüssel-Felds</param>
		/// <param name="resultMessage">Ergebnis in Text-Form</param>
		/// <returns>Ergebnis</returns>
		public static DBResultMessage TryDeleteDatesetByPK(DBTableDoublePK table, string primKeyValueOne, string primKeyValueTwo, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}
		#endregion

		#region private
		/// <summary>
		/// Versucht, eine Verbindung zur Datenbank 'ITVerwaltung' aufzubauen.
		/// Wenn Vorgang abgeschlossen, muss die Verbindung wieder geschlossen werden! -> sqlConnection.Close()
		/// </summary>
		/// <param name="exceptionString">Exception-Fehlermeldung, falls nicht erfolgreich.</param>
		/// <returns>Resultierende SQL-Connection - null, wenn nicht erfolgreich.</returns>
		private static SqlConnection TryOpenSqlConnection(out string exceptionString)
		{
			exceptionString = "";
			try
			{
				SqlConnection connection = new SqlConnection(
					$"user id={DB_LOGIN_NAME};"
					+ $"Password={DB_LOGIN_PW};"
					+ $"Server={DB_SERVER};"
					+ $"Trusted_Connection=yes;"
					+ $"Database={DB_NAME};"
					+ $"Connection Timeout={DB_CONN_TIMEOUT}");
				connection.Open();
				return connection;
			}
			catch (Exception e)
			{
				exceptionString = "Fehler: Es konnte keine Verbindung zur Datenbank geöffnet werden."
					+ $"\n{e.ToString()}";
				return null;
			}
		}
		#endregion
	}
}