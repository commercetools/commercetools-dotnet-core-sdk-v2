using System;


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
