using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction))]
    public partial interface IOrderChangePaymentStateAction : IOrderUpdateAction
    {
        IPaymentState PaymentState { get; set; }

    }
}
