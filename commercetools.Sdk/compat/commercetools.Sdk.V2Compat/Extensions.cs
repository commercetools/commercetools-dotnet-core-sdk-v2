using System;

namespace commercetools.Sdk.V2Compat
{
    public static class Extensions
    {
        public static string ToCamelCase(this string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 1)
            {
                return char.ToLowerInvariant(value[0]) + value.Substring(1);
            }

            return value;
        }
        public static bool IsAbstractClass(this Type type)
        {
            return type.IsClass && type.IsAbstract;
        }
    }
}