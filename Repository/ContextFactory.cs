using System.Web;

namespace Repository
{
    public class ContextFactory
    {
        public static string dbContextKey = "CompanyDB";
        public static CompanyDB GetDBContext()
        {

            if (HttpContext.Current.Items[dbContextKey] != null)
            {
                return (CompanyDB)HttpContext.Current.Items[dbContextKey];
            }

            var context = new CompanyDB();
            HttpContext.Current.Items[dbContextKey] = context;

            return context;
        }
    }
}
