using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChatDemo.Startup))]
namespace SignalRChatDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
