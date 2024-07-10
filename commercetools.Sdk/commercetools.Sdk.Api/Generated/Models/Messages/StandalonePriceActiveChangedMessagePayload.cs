namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceActiveChangedMessagePayload : IStandalonePriceActiveChangedMessagePayload
    {
        public string Type { get; set; }

        public bool Active { get; set; }

        public bool OldActive { get; set; }
        public StandalonePriceActiveChangedMessagePayload()
        {
            this.Type = "StandalonePriceActiveChanged";
        }
    }
}
