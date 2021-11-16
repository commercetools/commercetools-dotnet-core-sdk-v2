using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class StringSetField : IStringSetField
    {
        public string Type { get; set;}
        
        public List<string> Value { get; set;}
        public StringSetField()
        { 
           this.Type = "StringSet";
        }
    }
}
