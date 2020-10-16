using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("CartClassification")]
    public partial class CartClassificationType : ShippingRateInputType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
        public CartClassificationType()
        { 
           this.Type = "CartClassification";
        }
    }
}
