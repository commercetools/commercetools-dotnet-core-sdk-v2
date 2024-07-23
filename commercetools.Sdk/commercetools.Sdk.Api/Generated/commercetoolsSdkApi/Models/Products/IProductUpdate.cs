using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdate))]
    public partial interface IProductUpdate
    {
        long Version { get; set; }

        IList<IProductUpdateAction> Actions { get; set; }
        IEnumerable<IProductUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
