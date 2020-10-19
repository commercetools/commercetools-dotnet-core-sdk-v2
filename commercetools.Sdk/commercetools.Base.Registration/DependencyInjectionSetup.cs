using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace commercetools.Base.Registration
{
    /// <summary>
    /// Contains extensions methods to use when injecting dependencies.
    /// </summary>
    public static class DependencyInjectionSetup
    {
        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void UseRegistration(this IServiceCollection services)
        {
            services.TryAddSingleton<ITypeRetriever, TypeRetriever>();
        }
    }
}