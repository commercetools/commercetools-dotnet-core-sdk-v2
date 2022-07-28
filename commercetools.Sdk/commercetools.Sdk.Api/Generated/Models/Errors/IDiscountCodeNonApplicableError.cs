using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError))]
    public partial interface IDiscountCodeNonApplicableError : IErrorObject
    {
        string DiscountCode { get; set; }

        string Reason { get; set; }

        string DicountCodeId { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ValidityCheckTime { get; set; }

    }
}
