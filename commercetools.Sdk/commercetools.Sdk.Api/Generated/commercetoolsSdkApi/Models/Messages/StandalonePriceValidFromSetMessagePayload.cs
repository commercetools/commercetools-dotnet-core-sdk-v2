using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValidFromSetMessagePayload : IStandalonePriceValidFromSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? PreviousValidFrom { get; set; }
        public StandalonePriceValidFromSetMessagePayload()
        {
            this.Type = "StandalonePriceValidFromSet";
        }
    }
}
