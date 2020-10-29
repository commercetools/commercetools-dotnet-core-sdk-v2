using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    public interface IProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        List<IAttributeLocalizedEnumValue> Values { get; set;}
    }
}
