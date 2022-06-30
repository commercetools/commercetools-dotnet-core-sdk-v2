using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderFromQuoteDraft : IOrderFromQuoteDraft
    {
        public IQuoteResourceIdentifier Quote { get; set; }

        public long Version { get; set; }

        public string OrderNumber { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IOrderState OrderState { get; set; }

        public IStateResourceIdentifier State { get; set; }
    }
}
