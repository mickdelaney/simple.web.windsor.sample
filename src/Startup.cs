using Microsoft.Owin;
using Owin;
using Simple.Web.OwinSupport;
using Simple.Web.Windsor.Owin;
using Simple.Web.Windsor.Owin.Pipeline;

[assembly: OwinStartup(typeof(Startup))]
namespace Simple.Web.Windsor.Owin
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder builder) 
        {
            builder.Use(typeof(CustomTracer));
            builder.Map("/resources", sw => sw.UseSimpleWeb());
        }
    }

  
  

}
