using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValueChangedMessagePayload : IStandalonePriceValueChangedMessagePayload
    {
        public string Type { get; set; }

        public IMoney Value { get; set; }
        public StandalonePriceValueChangedMessagePayload()
        {
            this.Type = "StandalonePriceValueChanged";
        }
    }
}
