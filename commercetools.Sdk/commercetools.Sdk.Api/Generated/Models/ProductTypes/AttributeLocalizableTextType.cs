using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("ltext")]
    public partial class AttributeLocalizableTextType : AttributeType
    {
        public AttributeLocalizableTextType()
        { 
           this.Name = "ltext";
        }
    }
}
