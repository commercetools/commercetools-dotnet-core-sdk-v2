using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetReturnPaymentStateAction))]
    public partial interface IOrderSetReturnPaymentStateAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set;}
        
        IReturnPaymentState PaymentState { get; set;}
    }
}
