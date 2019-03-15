using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MichaelBrandonMorris.DependencyResolver
{
    /// <inheritdoc />
    public class Resolver : IDependencyResolver
    {
        public Resolver(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        private IServiceProvider ServiceProvider { get; }

        /// <inheritdoc />
        public object GetService(Type serviceType)
        {
            return ServiceProvider.GetService(serviceType);
        }

        /// <inheritdoc />
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ServiceProvider.GetServices(serviceType);
        }
    }
}
