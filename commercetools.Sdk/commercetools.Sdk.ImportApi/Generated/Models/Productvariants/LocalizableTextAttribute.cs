using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class LocalizableTextAttribute : ILocalizableTextAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public ILocalizedString Value { get; set;}
        public LocalizableTextAttribute()
        { 
           this.Type = "ltext";
        }
    }
}
