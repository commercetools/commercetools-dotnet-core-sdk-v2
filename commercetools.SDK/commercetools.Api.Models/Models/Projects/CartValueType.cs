using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("CartValue")]
    public partial class CartValueType : ShippingRateInputType
    {
        public CartValueType()
        { 
           this.Type = "CartValue";
        }
    }
}
