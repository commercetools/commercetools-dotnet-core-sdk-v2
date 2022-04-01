using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeUpdate))]
    public partial interface IProductTypeUpdate
    {
        long Version { get; set; }

        List<IProductTypeUpdateAction> Actions { get; set; }
    }
}
