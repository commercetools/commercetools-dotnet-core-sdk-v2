using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("CartScore")]
    public partial class CartScoreType : ShippingRateInputType
    {
        public CartScoreType()
        { 
           this.Type = "CartScore";
        }
    }
}
