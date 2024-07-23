using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderBillingAddressSetMessagePayload : IOrderBillingAddressSetMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }

        public IAddress OldAddress { get; set; }
        public OrderBillingAddressSetMessagePayload()
        {
            this.Type = "OrderBillingAddressSet";
        }
    }
}
