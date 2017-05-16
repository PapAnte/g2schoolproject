using System;
using System.Data.SqlClient;

namespace Bravo.ITVerwaltungDBInterface
{
	public static class ITVerwaltungDatabaseMgt
	{
		public const string DB_SERVER = "";
		public const string DB_NAME = "ITVerwaltung";
		public const string DB_LOGIN_NAME = "";
		public const string DB_LOGIN_PW = "";
		public const int DB_CONN_TIMEOUT = 15;

		public static DBResultMessage TryLogin(string username, string password, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		public static DBResultMessage FunctionTemplate(string infoOne, int infoTwo, out string resultMessage)
		{
			// TODO
			resultMessage = "Funktion nicht implementiert!";
			return DBResultMessage.Error;
		}

		/// <summary>
		/// Versucht, eine Verbindung zur Datenbank 'ITVerwaltung' aufzubauen.
		/// Wenn Vorgang abgeschlossen, muss die Verbindung wieder geschlossen werden! -> sqlConnection.Close()
		/// </summary>
		/// <param name="connection">Exception-Fehlermeldung, falls nicht erfolgreich.</param>
		/// <returns>SqlConnection-Objekt - null, wenn nicht erfolgreich.</returns>
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
				exceptionString = e.ToString();
				return null;
			}
		}
	}
}