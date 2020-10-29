using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldLocalizedEnumValue : ICustomFieldLocalizedEnumValue
    {
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
