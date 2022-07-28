using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdate))]
    public partial interface IProductDiscountUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductDiscountUpdate, IProductDiscountUpdateAction>
    {
        new long Version { get; set; }
        new List<IProductDiscountUpdateAction> Actions { get; set; }

    }
}
