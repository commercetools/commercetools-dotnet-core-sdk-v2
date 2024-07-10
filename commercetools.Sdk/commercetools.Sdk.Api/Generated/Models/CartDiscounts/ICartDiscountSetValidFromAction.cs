using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction))]
    public partial interface ICartDiscountSetValidFromAction : ICartDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }

    }
}
