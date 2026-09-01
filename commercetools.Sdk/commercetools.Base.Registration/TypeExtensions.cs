using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace commercetools.Base.Registration
{
    /// <summary>
    /// This class contains extensions methods for <see cref="Type"/>.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Gets all concrete types that the current type can be assigned from.
        /// </summary>
        /// <param name="currentType">The current type.</param>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The list of all concrete types that the current type can be assigned from.</returns>
        /// <remarks>For open generic types, this method loops through all base types and all interfaces and checks if any of them match the open generic type.</remarks>
        public static IEnumerable<Type> GetAllConcreteAssignableTypes(this Type currentType, Assembly assembly)
        {
            List<Type> types = new List<Type>();
            foreach (Type type in assembly.GetTypes())
            {
                if (currentType.IsGenericTypeDefinition)
                {
                    if (type != currentType && !type.IsAbstract && type.GetAllAssignableTypes().Where(t => t.IsGenericType).Select(t => t.GetGenericTypeDefinition()).Contains(currentType))
                    {
                        types.Add(type);
                    }
                }
                else
                {
                    if (type != currentType && !type.IsAbstract && currentType.IsAssignableFrom(type))
                    {
                        types.Add(type);
                    }
                }
            }

            return types;
        }

        /// <summary>
        /// Gets all types the specified type can be assigned from, including the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The list of all types the passed type can be assigned from.</returns>
        /// <remarks>This method returns the specified type, all base types and all interfaces.</remarks>
        public static IEnumerable<Type> GetAllAssignableTypes(this Type type)
        {
            if (type == null)
            {
                yield break;
            }

            yield return type;

            foreach (var i in type.GetInterfaces())
            {
                yield return i;
            }

            var currentBaseType = type.BaseType;
            while (currentBaseType != null)
            {
                yield return currentBaseType;
                currentBaseType = currentBaseType.BaseType;
            }
        }

        /// <summary>
        /// Get Types that marked with the passed custom attribute
        /// </summary>
        /// <param name="currentType">the type of the custom attribute</param>
        /// <returns>All types that have this custom attribute</returns>
        public static IEnumerable<Type> GetMarkedTypes(this Type currentType)
        {
            if (currentType == null)
            {
                throw new ArgumentNullException(nameof(currentType));
            }
            var declaringAssemblyName = currentType.Assembly.GetName().Name;
            var types =
                from a in AppDomain.CurrentDomain.GetAssemblies()
                where a.CanContainMarkedTypes(declaringAssemblyName) 
                from t in a.GetLoadableTypes()
                where t.GetCustomAttributes(currentType).Any()
                select t;
            return types;
        }

        private static bool CanContainMarkedTypes(this Assembly assembly, string declaringAssemblyName)
        {
            if (assembly.IsDynamic) 
                return false;
            if (string.Equals(assembly.GetName().Name, declaringAssemblyName, StringComparison.Ordinal))
            {
                return true;
            }

            try
            {
                return assembly.GetReferencedAssemblies().Any(reference =>
                    string.Equals(reference.Name, declaringAssemblyName, StringComparison.Ordinal));
            }
            catch (Exception)
            {
                return true;
            }
        }

        private static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            try
            {
                return assembly.GetTypes();
            } catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            } catch (Exception)
            {
                return Enumerable.Empty<Type>();
            }
        }
    }
}
