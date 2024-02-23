using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction))]
    public partial interface IProductDiscountSetValidFromAndUntilAction : IProductDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
