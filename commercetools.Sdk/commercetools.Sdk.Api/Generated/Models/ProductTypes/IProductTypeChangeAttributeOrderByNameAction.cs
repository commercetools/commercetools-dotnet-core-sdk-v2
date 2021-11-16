using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    public partial interface IProductTypeChangeAttributeOrderByNameAction : IProductTypeUpdateAction
    {
        List<string> AttributeNames { get; set; }
    }
}
