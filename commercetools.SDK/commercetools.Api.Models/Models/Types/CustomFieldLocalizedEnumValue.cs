using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public class CustomFieldLocalizedEnumValue 
    {
        public string Key { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}
