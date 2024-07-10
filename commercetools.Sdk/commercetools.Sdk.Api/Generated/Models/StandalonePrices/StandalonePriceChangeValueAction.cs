using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceChangeValueAction : IStandalonePriceChangeValueAction
    {
        public string Action { get; set; }

        public IMoney Value { get; set; }

        public bool? Staged { get; set; }
        public StandalonePriceChangeValueAction()
        {
            this.Action = "changeValue";
        }
    }
}
