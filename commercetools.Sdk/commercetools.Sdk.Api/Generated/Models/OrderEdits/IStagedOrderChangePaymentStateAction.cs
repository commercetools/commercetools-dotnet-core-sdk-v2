using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction))]
    public partial interface IStagedOrderChangePaymentStateAction : IStagedOrderUpdateAction
    {
        IPaymentState PaymentState { get; set; }

    }
}
