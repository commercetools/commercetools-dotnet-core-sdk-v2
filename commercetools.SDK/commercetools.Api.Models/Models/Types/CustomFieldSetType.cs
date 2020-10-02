using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Set")]
    public partial class CustomFieldSetType : FieldType
    {
        public FieldType ElementType { get; set;}
        public CustomFieldSetType()
        { 
           this.Name = "Set";
        }
    }
}
