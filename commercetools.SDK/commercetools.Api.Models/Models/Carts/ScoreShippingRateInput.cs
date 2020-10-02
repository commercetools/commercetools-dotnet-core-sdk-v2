using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("Score")]
    public partial class ScoreShippingRateInput : ShippingRateInput
    {
        public double Score { get; set;}
        public ScoreShippingRateInput()
        { 
           this.Type = "Score";
        }
    }
}
