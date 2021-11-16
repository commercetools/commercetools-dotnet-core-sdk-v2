using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction))]
    public partial interface IProductDiscountSetValidUntilAction : IProductDiscountUpdateAction
    {
        DateTime? ValidUntil { get; set; }
    }
}
