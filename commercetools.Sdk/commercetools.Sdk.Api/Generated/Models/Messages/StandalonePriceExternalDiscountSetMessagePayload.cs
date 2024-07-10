using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceExternalDiscountSetMessagePayload : IStandalonePriceExternalDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public IDiscountedPrice Discounted { get; set; }
        public StandalonePriceExternalDiscountSetMessagePayload()
        {
            this.Type = "StandalonePriceExternalDiscountSet";
        }
    }
}
