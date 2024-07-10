namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomFieldRemovedMessagePayload : IOrderCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public OrderCustomFieldRemovedMessagePayload()
        {
            this.Type = "OrderCustomFieldRemoved";
        }
    }
}
