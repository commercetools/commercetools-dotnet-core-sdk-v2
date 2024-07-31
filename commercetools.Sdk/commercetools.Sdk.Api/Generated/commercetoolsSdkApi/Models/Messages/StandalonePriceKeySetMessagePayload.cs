

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceKeySetMessagePayload : IStandalonePriceKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public StandalonePriceKeySetMessagePayload()
        {
            this.Type = "StandalonePriceKeySet";
        }
    }
}
