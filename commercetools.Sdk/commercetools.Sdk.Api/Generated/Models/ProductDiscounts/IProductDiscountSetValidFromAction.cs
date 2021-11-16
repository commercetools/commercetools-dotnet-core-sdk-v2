using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction))]
    public partial interface IProductDiscountSetValidFromAction : IProductDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set; }
    }
}
