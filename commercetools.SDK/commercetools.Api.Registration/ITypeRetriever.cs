using System;
using System.Collections.Generic;

namespace commercetools.Api.Registration
{
    /// <summary>
    /// Retrieves the types from an assembly.
    /// </summary>
    public interface ITypeRetriever
    {
        /// <summary>
        /// Gets the types from the same assembly as T that T is assignable from.
        /// </summary>
        /// <typeparam name="T">A type.</typeparam>
        /// <returns>The list of types.</returns>
        IEnumerable<Type> GetTypes<T>();
    }
}