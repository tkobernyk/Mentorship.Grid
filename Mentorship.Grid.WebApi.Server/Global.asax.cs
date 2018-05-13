using System.Web.Http;

namespace Mentorship.Grid.WebApi.Server
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configure(UnityConfig.Register);
        }
    }
}
