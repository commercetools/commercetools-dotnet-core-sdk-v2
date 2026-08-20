

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreContactUrlSetMessagePayload : IStoreContactUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string ContactUrl { get; set; }
        public StoreContactUrlSetMessagePayload()
        {
            this.Type = "StoreContactUrlSet";
        }
    }
}
