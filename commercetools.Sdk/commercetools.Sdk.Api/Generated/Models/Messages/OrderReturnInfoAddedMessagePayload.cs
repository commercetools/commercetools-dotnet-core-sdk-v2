using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderReturnInfoAddedMessagePayload : IOrderReturnInfoAddedMessagePayload
    {
        public string Type { get; set; }

        public IReturnInfo ReturnInfo { get; set; }
        public OrderReturnInfoAddedMessagePayload()
        {
            this.Type = "ReturnInfoAdded";
        }
    }
}
