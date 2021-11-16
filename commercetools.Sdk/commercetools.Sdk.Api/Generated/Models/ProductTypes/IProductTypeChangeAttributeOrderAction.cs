using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderAction))]
    public partial interface IProductTypeChangeAttributeOrderAction : IProductTypeUpdateAction
    {
        List<IAttributeDefinition> Attributes { get; set; }
    }
}
