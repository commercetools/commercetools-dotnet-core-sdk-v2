using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("datetime")]
    public partial class AttributeDateTimeType : AttributeType
    {
        public AttributeDateTimeType()
        { 
           this.Name = "datetime";
        }
    }
}
