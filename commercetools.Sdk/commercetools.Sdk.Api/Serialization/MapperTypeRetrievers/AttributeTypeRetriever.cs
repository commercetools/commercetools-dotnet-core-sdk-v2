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
        private readonly ISerializationConfiguration _serializationConfiguration;

        public AttributeTypeRetriever(ISerializationConfiguration serializationConfiguration = null)
        {
            this._serializationConfiguration = serializationConfiguration ?? SerializationConfiguration.DefaultConfig;
        }

        [Obsolete("use constructor without cultureValidator")]
        public AttributeTypeRetriever(ICultureValidator cultureValidator,
            ISerializationConfiguration serializationConfiguration = null) : this(serializationConfiguration)
        {
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
                    if (_serializationConfiguration.DeserializeNumberAttributeAsDecimalOnly)
                    {
                        tokenType = typeof(DecimalAttribute);
                    }
                    else
                    {
                        tokenType = element.IsLongOrInt() ? typeof(LongAttribute) : typeof(DecimalAttribute);
                    }
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
                    else if (element.IsNestedElement())
                        tokenType = typeof(Attribute);
                    else
                        tokenType = typeof(LocalizedStringAttribute);
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
                    if (_serializationConfiguration.DeserializeNumberAttributeAsDecimalOnly)
                    {
                        tokenType = typeof(decimal);
                    }
                    else
                    {
                        tokenType = element.IsLongOrInt() ? typeof(long) : typeof(decimal);
                    }
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
                    else if (element.IsNestedElement())
                        tokenType = typeof(IAttribute);
                    else
                        tokenType = typeof(LocalizedString);
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

        [Obsolete("use GetAttribute(attributeName, element) instead")]
        public IAttribute GetAttribute(JsonElement element)
        {
            var type = GetTypeForToken(element);
            return (IAttribute)Activator.CreateInstance(type);
        }
        
        public IAttribute GetAttribute(String attributeName, JsonElement element)
        {
            if (_serializationConfiguration.AttributeTypeMap.TryGetValue(attributeName, out var mappedType))
            {
                return (IAttribute)Activator.CreateInstance(mappedType);
            }
            var type = GetTypeForToken(element);
            return (IAttribute)Activator.CreateInstance(type);
        }

    }
}