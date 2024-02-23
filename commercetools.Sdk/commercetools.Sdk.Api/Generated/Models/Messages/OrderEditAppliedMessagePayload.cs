using commercetools.Sdk.Api.Models.OrderEdits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderEditAppliedMessagePayload : IOrderEditAppliedMessagePayload
    {
        public string Type { get; set; }

        public IOrderEdit Edit { get; set; }

        public IOrderEditApplied Result { get; set; }
        public OrderEditAppliedMessagePayload()
        {
            this.Type = "OrderEditApplied";
        }
    }
}
