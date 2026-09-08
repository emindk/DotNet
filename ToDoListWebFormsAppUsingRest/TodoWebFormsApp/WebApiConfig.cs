using System.Web.Http;

namespace TodoWebFormsApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Attribute routing'i etkinleştiriyoruz
            config.MapHttpAttributeRoutes();

            // Klasik routing örneği
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
