using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using HRMS_Intens.Models;
using HRMS_Intens.Interfaces;
using HRMS_Intens.Repository;
using HRMS_Intens.Resolver;

namespace HRMS_Intens
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // CORS
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Tracing
            config.EnableSystemDiagnosticsTracing();

            //Unity
            var container = new UnityContainer();
            container.RegisterType<ICandidateSkillRepository, CandidateSkillRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IJobCandidateRepository, JobCandidateRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);



        }
    }
}
