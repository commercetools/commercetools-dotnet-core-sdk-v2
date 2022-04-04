using System;
using System.Collections.Generic;
using System.Text.Json;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Validation;
using Attribute = commercetools.Sdk.Api.Models.Products.Attribute;

namespace commercetools.Sdk.Api.Serialization.MapperTypeRetrievers
{
    public class AttributeTypeRetriever
    {
        private readonly ICultureValidator _cultureValidator;

        public AttributeTypeRetriever(ICultureValidator cultureValidator)
        {
            this._cultureValidator = cultureValidator;
        }

        private Type GetTypeForToken(JsonElement element)
        {
            Type tokenType;
            var nodeType = element.ValueKind;
            switch (nodeType)
            {
                case JsonValueKind.True:
                case JsonValueKind.False:
                    tokenType = typeof(BooleanAttribute);
                    break;
                case JsonValueKind.Number:
                    tokenType = element.IsLongOrInt() ? typeof(LongAttribute) : typeof(DecimalAttribute);
                    break;
                case JsonValueKind.String:
                    tokenType = typeof(StringAttribute);
                    break;
                case JsonValueKind.Undefined:
                case JsonValueKind.Null:
                    tokenType = typeof(Attribute);
                    break;
                case JsonValueKind.Object:
                    if (element.IsEnumElement())
                        tokenType = typeof(PlainEnumAttribute);
                    else if (element.IsLocalizedEnumElement())
                        tokenType = typeof(LocalizedEnumAttribute);
                    else if (element.IsMoneyElement())
                        tokenType = typeof(MoneyAttribute);
                    else if (element.IsReferenceElement())
                        tokenType = typeof(ReferenceAttribute);
                    else if (element.IsLocalizedStringElement(_cultureValidator))
                        tokenType = typeof(LocalizedStringAttribute);
                    else
                        tokenType = typeof(Attribute);
                    break;
                case JsonValueKind.Array:
                    var valueKind = element.GetFirstArrayElementValueKind();
                    if (valueKind == JsonValueKind.Null)
                        tokenType = typeof(SetAttribute<>).MakeGenericType(typeof(object));
                    else if (element.GetFirstArrayElement().IsNestedElement())
                        tokenType = typeof(NestedAttribute);
                    else
                        tokenType = typeof(SetAttribute<>).MakeGenericType(GetElementTypeForToken(element.GetFirstArrayElement()));
                    break;
                default:
                    tokenType = typeof(Attribute);
                    break;
            }

            return tokenType;
        }

        private Type GetElementTypeForToken(JsonElement element)
        {
            Type tokenType;
            var nodeType = element.ValueKind;
            switch (nodeType)
            {
                case JsonValueKind.True:
                case JsonValueKind.False:
                    tokenType = typeof(bool);
                    break;
                case JsonValueKind.Number:
                    tokenType = element.IsLongOrInt() ? typeof(long) : typeof(decimal);
                    break;
                case JsonValueKind.String:
                    tokenType = typeof(string);
                    break;
                case JsonValueKind.Undefined:
                case JsonValueKind.Null:
                    tokenType = typeof(object);
                    break;
                case JsonValueKind.Object:
                    if (element.IsEnumElement())
                        tokenType = typeof(IAttributePlainEnumValue);
                    else if (element.IsLocalizedEnumElement())
                        tokenType = typeof(IAttributeLocalizedEnumValue);
                    else if (element.IsMoneyElement())
                        tokenType = typeof(ITypedMoney);
                    else if (element.IsReferenceElement())
                        tokenType = typeof(IReference);
                    else if (element.IsLocalizedStringElement(_cultureValidator))
                        tokenType = typeof(LocalizedString);
                    else if (element.IsNestedElement())
                        tokenType = typeof(IAttribute);
                    else
                        tokenType = typeof(object);
                    break;
                case JsonValueKind.Array:
                    var valueKind = element.GetFirstArrayElementValueKind();
                    var firstElementType = valueKind == JsonValueKind.Null
                        ? typeof(object)
                        : GetElementTypeForToken(element.GetFirstArrayElement());
                    tokenType = typeof(List<>).MakeGenericType(firstElementType);
                    break;
                default:
                    tokenType = typeof(object);
                    break;
            }

            return tokenType;
        }

        public IAttribute GetAttribute(JsonElement element)
        {
            var type = GetTypeForToken(element);
            return (IAttribute)Activator.CreateInstance(type);
        }
    }
}