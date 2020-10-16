using System;
using System.Collections.Generic;
using System.Reflection;

namespace commercetools.Base.Registration
{
    /// <summary>
    /// Retrieves the types from an assembly.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812", Justification = "instantiated using DI")]
    public class TypeRetriever : ITypeRetriever
    {
        /// <summary>
        /// Gets the types from the same assembly as T that T is assignable from.
        /// </summary>
        /// <typeparam name="T">A type.</typeparam>
        /// <returns>The list of types.</returns>
        public IEnumerable<Type> GetTypes<T>()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(T));
            return typeof(T).GetAllConcreteAssignableTypes(assembly);
        }
    }
}