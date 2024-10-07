using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReturnInfoAddedMessagePayload : IReturnInfoAddedMessagePayload
    {
        public string Type { get; set; }

        public IReturnInfo ReturnInfo { get; set; }
        public ReturnInfoAddedMessagePayload()
        {
            this.Type = "ReturnInfoAdded";
        }
    }
}
