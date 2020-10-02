using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace commercetools.Api.Models
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            return value.ToString();
        }

        public static object GetEnum(this string value, Type enumType)
        {
            var typeofEnum = enumType;

            if (!enumType.IsEnum && enumType.IsGenericType)
            {
                typeofEnum = Nullable.GetUnderlyingType(enumType);
            }

            if (typeofEnum != null && typeofEnum.IsEnum)
            {

                string[] names = Enum.GetNames(typeofEnum);
                foreach (string name in names)
                {
                    if (GetDescription((Enum) Enum.Parse(typeofEnum, name)).Equals(value))
                    {
                        return Enum.Parse(typeofEnum, name);
                    }
                }
            }

            throw new ArgumentException();
        }
        
        public static T GetEnum<T>(this string value) where T : Enum
        {
            string[] names = Enum.GetNames(typeof(T));
            foreach (string name in names)
            {
                if (GetDescription((Enum)Enum.Parse(typeof(T), name)).Equals(value))
                {
                    return (T)Enum.Parse(typeof(T), name);
                }
            }

            throw new ArgumentException($"Enum {typeof(T)} doesn't contains value {value}'");
        }
        
        public static List<T> GetEnum<T>(this List<string> values) where T : Enum
        {
            var enumList = new List<T>();
            foreach (var value in values)
            {
                enumList.Add(GetEnum<T>(value));
            }

            return enumList;
        }
    }
}