using DotVVM.Framework.Configuration;

namespace DotvvmNancyIntegration
{
    public class DotvvmStartup : IDotvvmStartup
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            RegisterRoutes(config);
            RegisterControls(config);
            RegisterResources(config);
        }

        private void RegisterRoutes(DotvvmConfiguration config)
        {
            config.RouteTable.Add("Default", "", "Views/default.dothtml");
        }

        private void RegisterControls(DotvvmConfiguration config)
        {

        }

        private void RegisterResources(DotvvmConfiguration config)
        {
            
        }
    }
}