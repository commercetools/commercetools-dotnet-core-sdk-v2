using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction))]
    public partial interface IProductTypeAddPlainEnumValueAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        IAttributePlainEnumValue Value { get; set;}
    }
}
