using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [SubTypeDiscriminator("ExtensionBadResponse", typeof(commercetools.Api.Models.Errors.ExtensionBadResponseError))]
    [SubTypeDiscriminator("ExtensionNoResponse", typeof(commercetools.Api.Models.Errors.ExtensionNoResponseError))]
    [SubTypeDiscriminator("ExtensionUpdateActionsFailed", typeof(commercetools.Api.Models.Errors.ExtensionUpdateActionsFailedError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.Api.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.Api.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidCurrentPassword", typeof(commercetools.Api.Models.Errors.InvalidCurrentPasswordError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Api.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Api.Models.Errors.InvalidInputError))]
    [SubTypeDiscriminator("InvalidItemShippingDetails", typeof(commercetools.Api.Models.Errors.InvalidItemShippingDetailsError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Api.Models.Errors.InvalidJsonInputError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Api.Models.Errors.InvalidOperationError))]
    [SubTypeDiscriminator("InvalidSubject", typeof(commercetools.Api.Models.Errors.InvalidSubjectError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.Api.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("LanguageUsedInStores", typeof(commercetools.Api.Models.Errors.LanguageUsedInStoresError))]
    [SubTypeDiscriminator("MatchingPriceNotFound", typeof(commercetools.Api.Models.Errors.MatchingPriceNotFoundError))]
    [SubTypeDiscriminator("MissingTaxRateForCountry", typeof(commercetools.Api.Models.Errors.MissingTaxRateForCountryError))]
    [SubTypeDiscriminator("NoMatchingProductDiscountFound", typeof(commercetools.Api.Models.Errors.NoMatchingProductDiscountFoundError))]
    [SubTypeDiscriminator("OutOfStock", typeof(commercetools.Api.Models.Errors.OutOfStockError))]
    [SubTypeDiscriminator("PriceChanged", typeof(commercetools.Api.Models.Errors.PriceChangedError))]
    [SubTypeDiscriminator("QueryTimedOut", typeof(commercetools.Api.Models.Errors.QueryTimedOutError))]
    [SubTypeDiscriminator("ReferenceExists", typeof(commercetools.Api.Models.Errors.ReferenceExistsError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Api.Models.Errors.ReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Api.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Api.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ShippingMethodDoesNotMatchCart", typeof(commercetools.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Api.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DiscountCodeNonApplicable", typeof(commercetools.Api.Models.Errors.DiscountCodeNonApplicableError))]
    [SubTypeDiscriminator("DuplicatePriceScope", typeof(commercetools.Api.Models.Errors.DuplicatePriceScopeError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Api.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Api.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Api.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.Api.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Api.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("EnumValueIsUsed", typeof(commercetools.Api.Models.Errors.EnumValueIsUsedError))]
    public partial interface IErrorObject 
    {
        string Code { get; set;}
        
        string Message { get; set;}
    }
}
