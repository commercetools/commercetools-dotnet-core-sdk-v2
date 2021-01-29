using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributePlainEnumValue))]
    public partial interface IAttributePlainEnumValue 
    {
        string Key { get; set;}
        
        string Label { get; set;}
    }
}
