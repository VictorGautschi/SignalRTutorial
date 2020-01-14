using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(SignalRTutorial.Startup))]
namespace SignalRTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            // ConfigureAuth(app);
        }
    }
}