using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("DateTime")]
    public partial class CustomFieldDateTimeType : FieldType
    {
        public CustomFieldDateTimeType()
        { 
           this.Name = "DateTime";
        }
    }
}
