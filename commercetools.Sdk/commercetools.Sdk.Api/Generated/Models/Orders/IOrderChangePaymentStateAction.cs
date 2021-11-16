using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderChangePaymentStateAction))]
    public partial interface IOrderChangePaymentStateAction : IOrderUpdateAction
    {
        IPaymentState PaymentState { get; set;}
    }
}
