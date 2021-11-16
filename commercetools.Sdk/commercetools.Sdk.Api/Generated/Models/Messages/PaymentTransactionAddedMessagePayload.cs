using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Messages
{
    public partial class PaymentTransactionAddedMessagePayload : IPaymentTransactionAddedMessagePayload
    {
        public string Type { get; set;}
        
        public ITransaction Transaction { get; set;}
        public PaymentTransactionAddedMessagePayload()
        { 
           this.Type = "PaymentTransactionAdded";
        }
    }
}
