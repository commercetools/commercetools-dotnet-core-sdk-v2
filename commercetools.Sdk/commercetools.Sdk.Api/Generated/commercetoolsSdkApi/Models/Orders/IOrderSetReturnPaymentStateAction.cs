using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnPaymentStateAction))]
    public partial interface IOrderSetReturnPaymentStateAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string ReturnItemKey { get; set; }

        IReturnPaymentState PaymentState { get; set; }

    }
}
