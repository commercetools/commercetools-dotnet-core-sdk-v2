using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("LocalizedString")]
    public partial class CustomFieldLocalizedStringType : FieldType
    {
        public CustomFieldLocalizedStringType()
        { 
           this.Name = "LocalizedString";
        }
    }
}
