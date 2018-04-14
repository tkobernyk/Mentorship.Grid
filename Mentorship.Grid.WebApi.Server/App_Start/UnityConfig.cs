using System.Web.Http;
using Unity.WebApi;
using Microsoft.Practices.Unity;

using Mentorship.Grid.DataAccess.Models;
using Mentorship.Grid.DataAccess.Interfaces;

namespace Mentorship.Grid.WebApi.Server
{
    public static class UnityConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}