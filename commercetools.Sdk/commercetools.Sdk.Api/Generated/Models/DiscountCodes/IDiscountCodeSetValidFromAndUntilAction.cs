using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetValidFromAndUntilAction))]
    public partial interface IDiscountCodeSetValidFromAndUntilAction : IDiscountCodeUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
