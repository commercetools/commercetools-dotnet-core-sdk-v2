using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction))]
    public partial interface IOrderChangePaymentStateAction : IOrderUpdateAction
    {
        IPaymentState PaymentState { get; set; }

    }
}
