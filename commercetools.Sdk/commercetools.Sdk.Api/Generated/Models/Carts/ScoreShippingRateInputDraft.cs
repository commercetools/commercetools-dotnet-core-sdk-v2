using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ScoreShippingRateInputDraft : IScoreShippingRateInputDraft
    {
        public string Type { get; set; }

        public long Score { get; set; }
        public ScoreShippingRateInputDraft()
        {
            this.Type = "Score";
        }
    }
}
