using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Extensions
{
    public static class AttributeExtensions
    {
        public static IAttribute Get(this List<IAttribute> attributes, string name)
        {
            return attributes.FirstOrDefault(a => a.Name.Equals(name));
        }
        
        public static T Get<T>(this List<IAttribute> attributes, string name) where T : IAttribute
        {
            return (T) attributes.FirstOrDefault(a => a.Name.Equals(name));
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
                attribute is IGenericAttribute<List<T>>;
        }
    }
}