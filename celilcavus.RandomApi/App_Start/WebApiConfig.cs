﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace celilcavus.RandomApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API yapılandırması ve hizmetleri
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            // Web API yolları
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new {action = RouteParameter.Optional, id = RouteParameter.Optional }
            );
        }
    }
}
