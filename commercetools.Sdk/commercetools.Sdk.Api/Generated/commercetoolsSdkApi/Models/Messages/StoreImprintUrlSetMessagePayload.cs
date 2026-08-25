

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreImprintUrlSetMessagePayload : IStoreImprintUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string ImprintUrl { get; set; }
        public StoreImprintUrlSetMessagePayload()
        {
            this.Type = "StoreImprintUrlSet";
        }
    }
}
