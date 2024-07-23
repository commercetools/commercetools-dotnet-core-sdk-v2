using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction))]
    public partial interface ICartDiscountSetValidFromAndUntilAction : ICartDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
