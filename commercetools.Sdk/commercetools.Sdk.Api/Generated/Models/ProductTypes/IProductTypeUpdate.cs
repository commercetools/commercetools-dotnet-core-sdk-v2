using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeUpdate))]
    public partial interface IProductTypeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductTypeUpdate, IProductTypeUpdateAction>
    {
        new long Version { get; set; }
        new IList<IProductTypeUpdateAction> Actions { get; set; }
        IEnumerable<IProductTypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
