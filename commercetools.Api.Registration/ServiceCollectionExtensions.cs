using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.Registration
{
    /// <summary>
    /// This class contains extensions methods for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds all concrete implementation types that are assignable from the specified service type to the service collection.
        /// </summary>
        /// <typeparam name="T">The service type.</typeparam>
        /// <param name="services">The services.</param>
        /// <param name="lifetime">The lifetime.</param>
        public static void RegisterAllTypes<T>(this IServiceCollection services, ServiceLifetime lifetime)
        {
            Type type = typeof(T);
            RegisterAllTypes(services, type, lifetime);
        }

        /// <summary>
        /// Adds all concrete implementation types that are assignable from the specified service type to the service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="type">The service type.</param>
        /// <param name="lifetime">The lifetime.</param>
        /// <remarks>In case the specified service type in an open generic type, first the concrete generic type is created based on the retrieved implementation type.</remarks>
        public static void RegisterAllTypes(this IServiceCollection services, Type type, ServiceLifetime lifetime)
        {
            Assembly assembly = Assembly.GetAssembly(type);
            var typesToRegister = type.GetAllConcreteAssignableTypes(assembly);
            foreach (var implementationType in typesToRegister)
            {
                Type typeToRegister = type;
                if (type.IsGenericTypeDefinition)
                {
                    typeToRegister = GetTypeForGenericTypeDefinition(type, implementationType);
                }

                services.Add(new ServiceDescriptor(typeToRegister, implementationType, lifetime));
            }
        }

        /// <summary>
        /// Gets the concrete generic type for the specified open generic type.
        /// </summary>
        /// <param name="openGenericType">The open generic type.</param>
        /// <param name="concreteType">The concrete type from which the generic parameter is retrieved.</param>
        /// <returns>The concrete generic type.</returns>
        /// <remarks>
        /// GenericType&lt;&gt;
        /// ConcreteType: GenericType&lt;T&gt;
        /// returns GenericType&lt;T&gt;
        /// </remarks>
        private static Type GetTypeForGenericTypeDefinition(Type openGenericType, Type concreteType)
        {
            foreach (Type type in concreteType.GetAllAssignableTypes())
            {
                if (type.IsGenericType && type.GetGenericTypeDefinition() == openGenericType)
                {
                    return type;
                }
            }

            return null;
        }
    }
}
