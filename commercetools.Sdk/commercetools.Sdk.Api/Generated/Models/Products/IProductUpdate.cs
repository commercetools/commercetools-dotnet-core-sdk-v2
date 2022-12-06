using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdate))]
    public partial interface IProductUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductUpdate, IProductUpdateAction>
    {
        new long Version { get; set; }
        new IList<IProductUpdateAction> Actions { get; set; }
        IEnumerable<IProductUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
