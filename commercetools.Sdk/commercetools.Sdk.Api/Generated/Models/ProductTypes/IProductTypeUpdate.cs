using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeUpdate))]
    public partial interface IProductTypeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProductTypeUpdate, IProductTypeUpdateAction>
    {
        new long Version { get; set; }
        new List<IProductTypeUpdateAction> Actions { get; set; }

    }
}
