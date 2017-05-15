namespace Bravo.ITVerwaltungDBInterface
{
	public static class ITVerwaltungDatabaseMgt
	{
		public const string DB_SERVER = "";
		public const string DB_NAME = "";
		public const string DB_LOGIN_NAME = "";
		public const string DB_LOGIN_PW = "";

		public static DBResult FunctionTemplate(string infoOne, int infoTwo, out string resultMessage)
		{
			resultMessage = "Not implemented!";
			return DBResult.Error;
		}
	}
}