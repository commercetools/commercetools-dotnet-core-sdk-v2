using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction))]
    public partial interface IProductDiscountSetValidFromAction : IProductDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }
    }
}
