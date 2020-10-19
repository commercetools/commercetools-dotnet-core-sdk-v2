using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Time")]
    public partial class CustomFieldTimeType : FieldType
    {
        public CustomFieldTimeType()
        { 
           this.Name = "Time";
        }
    }
}
