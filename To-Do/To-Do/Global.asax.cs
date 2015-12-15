using System;
using System.Web;
using System.Web.Http;

using To_Do.AppStart;

namespace To_Do
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}