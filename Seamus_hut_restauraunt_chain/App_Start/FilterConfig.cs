using System.Web;
using System.Web.Mvc;

namespace Seamus_hut_restauraunt_chain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
