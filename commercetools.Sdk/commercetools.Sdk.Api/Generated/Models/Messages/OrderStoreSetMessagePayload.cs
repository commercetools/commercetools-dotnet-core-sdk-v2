using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class OrderStoreSetMessagePayload : IOrderStoreSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public OrderStoreSetMessagePayload()
        {
            this.Type = "OrderStoreSet";
        }
    }
}
