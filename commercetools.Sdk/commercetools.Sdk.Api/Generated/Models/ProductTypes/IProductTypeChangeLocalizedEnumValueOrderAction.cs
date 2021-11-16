using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        List<IAttributeLocalizedEnumValue> Values { get; set;}
    }
}
