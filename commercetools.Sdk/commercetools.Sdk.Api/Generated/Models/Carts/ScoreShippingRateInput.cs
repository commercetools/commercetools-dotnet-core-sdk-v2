using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public string Type { get; set;}
        
        public double Score { get; set;}
        public ScoreShippingRateInput()
        { 
           this.Type = "Score";
        }
    }
}
