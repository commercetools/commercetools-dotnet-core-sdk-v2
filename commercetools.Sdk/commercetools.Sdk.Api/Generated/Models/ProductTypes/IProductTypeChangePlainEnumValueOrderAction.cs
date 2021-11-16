using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    public partial interface IProductTypeChangePlainEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        List<IAttributePlainEnumValue> Values { get; set;}
    }
}
