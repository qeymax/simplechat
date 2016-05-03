using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Routing;

[assembly: OwinStartup(typeof(simplechat.Startup1))]

namespace simplechat
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
        }

    }
}
