using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public IShippingRateInputType Type { get; set;}
        
        public double Score { get; set;}
        public ScoreShippingRateInput()
        { 
           this.Type = IShippingRateInputType.FindEnum("Score");
        }
    }
}
