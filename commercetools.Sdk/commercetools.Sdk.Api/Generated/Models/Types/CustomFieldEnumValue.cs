using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class CustomFieldEnumValue : ICustomFieldEnumValue
    {
        public string Key { get; set;}
        
        public string Label { get; set;}
    }
}
