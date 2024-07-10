using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValidFromAndUntilSetMessagePayload : IStandalonePriceValidFromAndUntilSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? PreviousValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public DateTime? PreviousValidUntil { get; set; }
        public StandalonePriceValidFromAndUntilSetMessagePayload()
        {
            this.Type = "StandalonePriceValidFromAndUntilSet";
        }
    }
}
