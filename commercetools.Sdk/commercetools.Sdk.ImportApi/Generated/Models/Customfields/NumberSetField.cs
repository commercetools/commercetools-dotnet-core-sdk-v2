using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class NumberSetField : INumberSetField
    {
        public string Type { get; set;}
        
        public List<double> Value { get; set;}
        public NumberSetField()
        { 
           this.Type = "NumberSet";
        }
    }
}
