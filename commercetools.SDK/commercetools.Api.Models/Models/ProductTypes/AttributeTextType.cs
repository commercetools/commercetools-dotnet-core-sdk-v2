using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("text")]
    public partial class AttributeTextType : AttributeType
    {
        public AttributeTextType()
        { 
           this.Name = "text";
        }
    }
}
