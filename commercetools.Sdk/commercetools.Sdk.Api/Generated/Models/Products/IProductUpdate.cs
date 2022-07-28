using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdate))]
    public partial interface IProductUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductUpdate, IProductUpdateAction>
    {
        new long Version { get; set; }
        new List<IProductUpdateAction> Actions { get; set; }

    }
}
