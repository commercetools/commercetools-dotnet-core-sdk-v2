using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetValidUntilAction : IStandalonePriceSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public StandalonePriceSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
