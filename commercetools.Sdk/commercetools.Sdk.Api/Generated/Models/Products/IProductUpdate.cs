using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdate))]
    public partial interface IProductUpdate
    {
        long Version { get; set; }

        List<IProductUpdateAction> Actions { get; set; }
    }
}
