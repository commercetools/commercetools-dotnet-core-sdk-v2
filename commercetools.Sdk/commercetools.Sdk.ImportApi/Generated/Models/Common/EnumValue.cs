using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class EnumValue : IEnumValue
    {
        public string Key { get; set;}
        
        public string Label { get; set;}
    }
}
