using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductUpdate))]
    public partial interface IProductUpdate
    {
        long Version { get; set; }

        List<IProductUpdateAction> Actions { get; set; }
    }
}
