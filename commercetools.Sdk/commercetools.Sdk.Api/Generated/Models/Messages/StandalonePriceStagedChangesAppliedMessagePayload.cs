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

    public partial class StandalonePriceStagedChangesAppliedMessagePayload : IStandalonePriceStagedChangesAppliedMessagePayload
    {
        public string Type { get; set; }

        public IStagedStandalonePrice StagedChanges { get; set; }
        public StandalonePriceStagedChangesAppliedMessagePayload()
        {
            this.Type = "StandalonePriceStagedChangesApplied";
        }
    }
}
