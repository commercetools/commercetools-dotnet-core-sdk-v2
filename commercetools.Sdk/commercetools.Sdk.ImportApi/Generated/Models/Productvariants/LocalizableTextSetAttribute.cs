using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class LocalizableTextSetAttribute : ILocalizableTextSetAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public List<ILocalizedString> Value { get; set;}
        public LocalizableTextSetAttribute()
        { 
           this.Type = "ltext-set";
        }
    }
}
