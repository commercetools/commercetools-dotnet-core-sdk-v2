using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction))]
    public partial interface IProductDiscountSetValidFromAndUntilAction : IProductDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set;}
        
        DateTime? ValidUntil { get; set;}
    }
}
