using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValidUntilSetMessagePayload : IStandalonePriceValidUntilSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime? ValidUntil { get; set; }

        public DateTime? PreviousValidUntil { get; set; }
        public StandalonePriceValidUntilSetMessagePayload()
        {
            this.Type = "StandalonePriceValidUntilSet";
        }
    }
}
