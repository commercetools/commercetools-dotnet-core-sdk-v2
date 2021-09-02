using System.Collections.Generic;
using System.Text.Json;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Base.Validation;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.MapperTypeRetrievers
{
    public class FieldMapperTypeRetriever : MapperTypeRetriever<IFieldContainer>
    {
        private readonly ICultureValidator _cultureValidator;

        public FieldMapperTypeRetriever(ICultureValidator cultureValidator)
        {
            this._cultureValidator = cultureValidator;
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
                    else if (element.IsLocalizedStringElement(_cultureValidator))
                        tokenType = typeof(LocalizedString);
                    else
                        tokenType = typeof(object);
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