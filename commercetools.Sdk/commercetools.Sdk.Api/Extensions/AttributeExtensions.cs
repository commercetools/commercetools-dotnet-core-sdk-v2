using System.Collections.Generic;
using System.Linq;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Extensions
{
    public static class AttributeExtensions
    {
        public static IAttribute Get(this IList<IAttribute> attributes, string name)
        {
            return attributes.FirstOrDefault(a => a.Name.Equals(name));
        }

        public static IProductTailoringAttribute Get(this IList<IProductTailoringAttribute> attributes, string name)
        {
            return attributes.FirstOrDefault(a => a.Name.Equals(name));
        }

        public static T Get<T>(this IList<IAttribute> attributes, string name) where T : IAttribute
        {
            var t = attributes.FirstOrDefault(a => a.Name.Equals(name));
            if (t is LongAttribute l && typeof(T).IsAssignableFrom(typeof(DecimalAttribute)))
            {
                var toD = (DecimalAttribute)l;
                return (T)(IAttribute)toD;
            }
            if (t is DecimalAttribute d && typeof(T).IsAssignableFrom(typeof(LongAttribute)))
            {
                var toL = (LongAttribute)d;
                return (T)(IAttribute)toL;
            }
            return (T)t;
        }

        public static T Get<T>(this IList<IProductTailoringAttribute> attributes, string name) where T : IProductTailoringAttribute
        {
            var t = attributes.FirstOrDefault(a => a.Name.Equals(name));
            if (t is LongAttribute l && typeof(T).IsAssignableFrom(typeof(DecimalAttribute)))
            {
                var toD = (DecimalAttribute)l;
                return (T)(IAttribute)toD;
            }
            if (t is DecimalAttribute d && typeof(T).IsAssignableFrom(typeof(LongAttribute)))
            {
                var toL = (LongAttribute)d;
                return (T)(IAttribute)toL;
            }
            return (T)t;
        }

        public static bool IsTextAttribute(this IAttribute attribute)
        {
            return
                attribute is IGenericAttribute<string>;
        }


        public static bool IsBooleanAttribute(this IAttribute attribute)
        {
            return
                attribute is BooleanAttribute;
        }

        public static bool IsEnumAttribute(this IAttribute attribute)
        {
            return
                attribute is PlainEnumAttribute;
        }
        public static bool IsLocalizedEnumAttribute(this IAttribute attribute)
        {
            return
                attribute is LocalizedEnumAttribute;
        }

        public static bool IsLocalizedStringAttribute(this IAttribute attribute)
        {
            return
                attribute is LocalizedStringAttribute;
        }

        public static bool IsMoneyAttribute(this IAttribute attribute)
        {
            return
                attribute is MoneyAttribute;
        }

        public static bool IsDecimalAttribute(this IAttribute attribute)
        {
            return
                attribute is DecimalAttribute;
        }

        public static bool IsLongAttribute(this IAttribute attribute)
        {
            return
                attribute is LongAttribute;
        }

        public static bool IsReferenceAttribute(this IAttribute attribute)
        {
            return
                attribute is ReferenceAttribute;
        }

        public static bool IsNestedAttribute(this IAttribute attribute)
        {
            return
                attribute is NestedAttribute ||
                attribute is IGenericAttribute<List<IAttribute>>;
        }

        public static bool IsSetBooleanAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<bool>;
        }

        public static bool IsSetMoneyAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<ITypedMoney>;
        }

        public static bool IsSetEnumAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<IAttributePlainEnumValue>;
        }

        public static bool IsSetLocalizedEnumAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<IAttributeLocalizedEnumValue>;
        }

        public static bool IsSetLocalizedStringAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<LocalizedString>;
        }

        public static bool IsSetDecimalAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<decimal>;
        }

        public static bool IsSetLongAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<long>;
        }

        public static bool IsSetReferenceAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<IReference>;
        }

        public static bool IsSetStringAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<string>;
        }

        public static bool IsSetOfNestedAttribute(this IAttribute attribute)
        {
            return
                attribute is SetAttribute<List<IAttribute>>;
        }

        public static bool IsSetAttribute<T>(this IAttribute attribute)
        {
            return
                attribute is IGenericAttribute<IList<T>>;
        }
    }
}