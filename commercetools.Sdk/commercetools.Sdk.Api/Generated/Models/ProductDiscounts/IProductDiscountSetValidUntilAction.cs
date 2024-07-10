using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction))]
    public partial interface IProductDiscountSetValidUntilAction : IProductDiscountUpdateAction
    {
        DateTime? ValidUntil { get; set; }

    }
}
