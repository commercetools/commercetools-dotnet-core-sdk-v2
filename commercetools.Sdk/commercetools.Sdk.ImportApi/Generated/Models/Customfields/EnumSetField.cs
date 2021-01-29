using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class EnumSetField : IEnumSetField
    {
        public string Type { get; set;}
        
        public List<string> Value { get; set;}
        public EnumSetField()
        { 
           this.Type = "EnumSet";
        }
    }
}
