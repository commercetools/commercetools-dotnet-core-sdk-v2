using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    public partial interface IProductTypeRemoveEnumValuesAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        List<string> Keys { get; set;}
    }
}
