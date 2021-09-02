using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ScoreShippingRateInputDraft : IScoreShippingRateInputDraft
    {
        public string Type { get; set; }

        public double Score { get; set; }
        public ScoreShippingRateInputDraft()
        {
            this.Type = "Score";
        }
    }
}
