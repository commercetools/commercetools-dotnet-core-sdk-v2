

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreOrderUrlTemplateSetMessagePayload : IStoreOrderUrlTemplateSetMessagePayload
    {
        public string Type { get; set; }

        public string OrderUrlTemplate { get; set; }
        public StoreOrderUrlTemplateSetMessagePayload()
        {
            this.Type = "StoreOrderUrlTemplateSet";
        }
    }
}
