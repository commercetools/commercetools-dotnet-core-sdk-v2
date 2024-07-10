using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceCreatedMessagePayload : IStandalonePriceCreatedMessagePayload
    {
        public string Type { get; set; }

        public IStandalonePrice StandalonePrice { get; set; }
        public StandalonePriceCreatedMessagePayload()
        {
            this.Type = "StandalonePriceCreated";
        }
    }
}
