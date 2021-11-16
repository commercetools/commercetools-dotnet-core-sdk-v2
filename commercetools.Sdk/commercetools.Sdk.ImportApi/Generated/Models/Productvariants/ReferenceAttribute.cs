using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class ReferenceAttribute : IReferenceAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public IKeyReference Value { get; set;}
        public ReferenceAttribute()
        { 
           this.Type = "reference";
        }
    }
}
