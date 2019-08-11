using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ServiceStack;

namespace MyApp
{
    public class ConfigureUi : IConfigureAppHost
    {
        public void Configure(IAppHost appHost)
        {
            appHost.CustomErrorHttpHandlers[HttpStatusCode.NotFound] = new SharpPageHandler("/notfound");
            appHost.CustomErrorHttpHandlers[HttpStatusCode.Forbidden] = new SharpPageHandler("/forbidden");
            
            Svg.Load(appHost.RootDirectory.GetDirectory("/assets/svg"));
            Svg.CssFillColor["svg-icons"] = "#2f495e";
        }
    }
}

