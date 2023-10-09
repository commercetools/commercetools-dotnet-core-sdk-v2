using System;
using System.Collections.Generic;
using System.Text.Json;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Base.Validation;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.MapperTypeRetrievers
{
    public class AttributeMapperTypeRetriever : MapperTypeRetriever<IAttribute>
    {
        private readonly ISerializationConfiguration _serializationConfiguration;

        public AttributeMapperTypeRetriever(ISerializationConfiguration serializationConfiguration = null)
        {
            this._serializationConfiguration = serializationConfiguration ?? SerializationConfiguration.DefaultConfig;
        }

        [Obsolete("use constructor without cultureValidator")]
        public AttributeMapperTypeRetriever(ICultureValidator cultureValidator, ISerializationConfiguration serializationConfiguration = null) : this(serializationConfiguration)
        {
        }

        public override Type GetTypeForToken(JsonElement element)
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
                        : GetTypeForToken(element.GetFirstArrayElement());
                    tokenType = typeof(List<>).MakeGenericType(firstElementType);
                    break;
                default:
                    tokenType = typeof(object);
                    break;
            }

            return tokenType;
        }
    }
}