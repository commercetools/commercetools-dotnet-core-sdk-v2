using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Events
{

    public partial class CheckoutMessagePaymentsPayloadBaseData : ICheckoutMessagePaymentsPayloadBaseData
    {
        public string ProjectKey { get; set; }

        public IPaymentReference Payment { get; set; }

        public string TransactionId { get; set; }

        public ICartReference Cart { get; set; }

        public IOrderReference Order { get; set; }
    }
}
