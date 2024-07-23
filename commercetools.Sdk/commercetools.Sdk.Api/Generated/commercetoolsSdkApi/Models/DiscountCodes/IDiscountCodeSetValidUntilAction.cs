using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidUntilAction))]
    public partial interface IDiscountCodeSetValidUntilAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidUntil { get; set; }

    }
}
