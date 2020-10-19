using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Money")]
    public partial class CustomFieldMoneyType : FieldType
    {
        public CustomFieldMoneyType()
        { 
           this.Name = "Money";
        }
    }
}
