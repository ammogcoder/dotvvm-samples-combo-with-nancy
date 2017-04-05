using System;
using System.Threading.Tasks;
using System.Web.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DotvvmNancyIntegration.Startup))]

namespace DotvvmNancyIntegration
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var applicationPath = HostingEnvironment.ApplicationPhysicalPath;
            app.UseDotVVM<DotvvmStartup>(applicationPath, options: options =>
            {
                options.AddDefaultTempStorages("temp");
            });

            app.UseNancy();
        }
    }
}
