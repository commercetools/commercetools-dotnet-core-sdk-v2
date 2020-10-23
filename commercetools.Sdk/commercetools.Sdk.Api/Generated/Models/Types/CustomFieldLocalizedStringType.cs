using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class CustomFieldLocalizedStringType : ICustomFieldLocalizedStringType
    {
        public string Name { get; set;}
        public CustomFieldLocalizedStringType()
        { 
           this.Name = "LocalizedString";
        }
    }
}
