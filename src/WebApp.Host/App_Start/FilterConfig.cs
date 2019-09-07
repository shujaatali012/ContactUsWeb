/// <summary>
/// Application Filter Configuration
/// </summary>

namespace WebApp.Host
{
    #region namespaces

    using System.Web.Mvc;

    #endregion

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
