using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError))]
    public partial interface IDiscountCodeNonApplicableError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string DiscountCode { get; set; }

        string Reason { get; set; }

        string DiscountCodeId { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ValidityCheckTime { get; set; }

    }
}
