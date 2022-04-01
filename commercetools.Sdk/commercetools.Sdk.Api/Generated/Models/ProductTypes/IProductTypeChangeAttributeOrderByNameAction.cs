using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    public partial interface IProductTypeChangeAttributeOrderByNameAction : IProductTypeUpdateAction
    {
        List<string> AttributeNames { get; set; }
    }
}
