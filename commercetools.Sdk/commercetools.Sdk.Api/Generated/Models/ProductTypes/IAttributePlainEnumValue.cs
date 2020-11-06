using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributePlainEnumValue))]
    public partial interface IAttributePlainEnumValue 
    {
        string Key { get; set;}
        
        string Label { get; set;}
    }
}
