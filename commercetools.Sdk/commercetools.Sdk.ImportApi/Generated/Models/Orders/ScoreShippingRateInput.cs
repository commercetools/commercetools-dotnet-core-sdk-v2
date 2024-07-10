using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ScoreShippingRateInput : IScoreShippingRateInput
    {
        public IShippingRateInputType Type { get; set; }

        public long Score { get; set; }
        public ScoreShippingRateInput()
        {
            this.Type = IShippingRateInputType.FindEnum("Score");
        }
    }
}
