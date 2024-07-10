using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValueChangedMessagePayload : IStandalonePriceValueChangedMessagePayload
    {
        public string Type { get; set; }

        public ITypedMoney Value { get; set; }

        public bool Staged { get; set; }

        public ITypedMoney OldValue { get; set; }
        public StandalonePriceValueChangedMessagePayload()
        {
            this.Type = "StandalonePriceValueChanged";
        }
    }
}
