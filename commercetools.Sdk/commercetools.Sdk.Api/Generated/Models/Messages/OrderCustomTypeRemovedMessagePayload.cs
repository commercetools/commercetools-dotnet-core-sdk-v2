namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomTypeRemovedMessagePayload : IOrderCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }
        public OrderCustomTypeRemovedMessagePayload()
        {
            this.Type = "OrderCustomTypeRemoved";
        }
    }
}
