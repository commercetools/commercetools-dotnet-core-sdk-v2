using System;
using System.Collections.Generic;
using System.Text.Json;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Base.Validation;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.MapperTypeRetrievers
{
    public class FieldMapperTypeRetriever : MapperTypeRetriever<IFieldContainer>
    {
        public FieldMapperTypeRetriever()
        {
        }

        [Obsolete("use constructor without cultureValidator")]
        public FieldMapperTypeRetriever(ICultureValidator cultureValidator) : this()
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
                    if (element.IsMoneyElement())
                        tokenType = typeof(ITypedMoney);
                    else if (element.IsReferenceElement())
                        tokenType = typeof(IReference);
                    else
                        tokenType = typeof(LocalizedString);
                    break;
                case JsonValueKind.Array:
                    var valueKind = element.GetFirstArrayElementValueKind();
                    var firstElementType = valueKind == JsonValueKind.Null ?
                        typeof(object) :
                        GetTypeForToken(element.GetFirstArrayElement());
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