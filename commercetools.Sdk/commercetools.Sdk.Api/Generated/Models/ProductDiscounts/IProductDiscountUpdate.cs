using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdate))]
    public partial interface IProductDiscountUpdate
    {
        long Version { get; set; }

        List<IProductDiscountUpdateAction> Actions { get; set; }
    }
}
