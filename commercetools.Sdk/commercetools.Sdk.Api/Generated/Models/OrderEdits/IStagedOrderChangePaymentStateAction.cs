using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction))]
    public partial interface IStagedOrderChangePaymentStateAction : IStagedOrderUpdateAction
    {
        IPaymentState PaymentState { get; set; }
    }
}
