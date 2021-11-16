using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderAddPaymentAction : IOrderAddPaymentAction
    {
        public string Action { get; set;}
        
        public IPaymentResourceIdentifier Payment { get; set;}
        public OrderAddPaymentAction()
        { 
           this.Action = "addPayment";
        }
    }
}
