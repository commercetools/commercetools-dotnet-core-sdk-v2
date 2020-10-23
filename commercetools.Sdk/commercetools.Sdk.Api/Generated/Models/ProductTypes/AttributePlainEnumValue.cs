using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public  partial class AttributePlainEnumValue : IAttributePlainEnumValue
    {
        public string Key { get; set;}
        
        public string Label { get; set;}
    }
}
