using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace DotvvmNancyIntegration.Modules
{
    public class HelloModule : NancyModule
    {

        public HelloModule() : base("/nancy/hello")
        {
            Get[""] = parameters => "Hello from Nancy!";
        }

    }
}