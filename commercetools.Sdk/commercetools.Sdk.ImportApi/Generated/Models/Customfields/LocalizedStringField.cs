using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class LocalizedStringField : ILocalizedStringField
    {
        public string Type { get; set;}
        
        public ILocalizedString Value { get; set;}
        public LocalizedStringField()
        { 
           this.Type = "LocalizedString";
        }
    }
}
