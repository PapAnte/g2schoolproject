using System.Web;
using System.Web.SessionState;

namespace Bravo
{
	public static class SessionVarMgt
	{
		public static string UserLoggedIn
		{
			get
			{
				object foo = Session[nameof(UserLoggedIn)];
				if (foo == null)
					return "";
				else
					return (string)foo;
			}
			set { Session["Test"] = value; }
		}

		private static HttpSessionState Session => HttpContext.Current.Session;
	}
}