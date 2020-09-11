using commercetools.Api.Models.Errors;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    [JsonConverter(typeof(JsonSubtypes), "code")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionBadResponseError), "ExtensionBadResponse")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionNoResponseError), "ExtensionNoResponse")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionUpdateActionsFailedError), "ExtensionUpdateActionsFailed")]
    [JsonSubtypes.KnownSubType(typeof(InsufficientScopeError), "insufficient_scope")]
    [JsonSubtypes.KnownSubType(typeof(InvalidCredentialsError), "InvalidCredentials")]
    [JsonSubtypes.KnownSubType(typeof(InvalidCurrentPasswordError), "InvalidCurrentPassword")]
    [JsonSubtypes.KnownSubType(typeof(InvalidFieldError), "InvalidField")]
    [JsonSubtypes.KnownSubType(typeof(InvalidInputError), "InvalidInput")]
    [JsonSubtypes.KnownSubType(typeof(InvalidItemShippingDetailsError), "InvalidItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(InvalidJsonInputError), "InvalidJsonInput")]
    [JsonSubtypes.KnownSubType(typeof(InvalidOperationError), "InvalidOperation")]
    [JsonSubtypes.KnownSubType(typeof(InvalidSubjectError), "InvalidSubject")]
    [JsonSubtypes.KnownSubType(typeof(InvalidTokenError), "invalid_token")]
    [JsonSubtypes.KnownSubType(typeof(LanguageUsedInStoresError), "LanguageUsedInStores")]
    [JsonSubtypes.KnownSubType(typeof(MatchingPriceNotFoundError), "MatchingPriceNotFound")]
    [JsonSubtypes.KnownSubType(typeof(MissingTaxRateForCountryError), "MissingTaxRateForCountry")]
    [JsonSubtypes.KnownSubType(typeof(NoMatchingProductDiscountFoundError), "NoMatchingProductDiscountFound")]
    [JsonSubtypes.KnownSubType(typeof(OutOfStockError), "OutOfStock")]
    [JsonSubtypes.KnownSubType(typeof(PriceChangedError), "PriceChanged")]
    [JsonSubtypes.KnownSubType(typeof(ReferenceExistsError), "ReferenceExists")]
    [JsonSubtypes.KnownSubType(typeof(RequiredFieldError), "RequiredField")]
    [JsonSubtypes.KnownSubType(typeof(ResourceNotFoundError), "ResourceNotFound")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodDoesNotMatchCartError), "ShippingMethodDoesNotMatchCart")]
    [JsonSubtypes.KnownSubType(typeof(DuplicatePriceScopeError), "DuplicatePriceScope")]
    [JsonSubtypes.KnownSubType(typeof(ConcurrentModificationError), "ConcurrentModification")]
    [JsonSubtypes.KnownSubType(typeof(EnumValueIsUsedError), "EnumValueIsUsed")]
    [JsonSubtypes.KnownSubType(typeof(DuplicateFieldError), "DuplicateField")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeNonApplicableError), "DiscountCodeNonApplicable")]
    [JsonSubtypes.KnownSubType(typeof(DuplicateAttributeValuesError), "DuplicateAttributeValues")]
    [JsonSubtypes.KnownSubType(typeof(DuplicateAttributeValueError), "DuplicateAttributeValue")]
    [JsonSubtypes.KnownSubType(typeof(DuplicateFieldWithConflictingResourceError), "DuplicateFieldWithConflictingResource")]
    [JsonSubtypes.KnownSubType(typeof(DuplicateVariantValuesError), "DuplicateVariantValues")]
    [JsonSubtypes.KnownSubType(typeof(AccessDeniedError), "access_denied")]
    public abstract class ErrorObject 
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
    }
}
