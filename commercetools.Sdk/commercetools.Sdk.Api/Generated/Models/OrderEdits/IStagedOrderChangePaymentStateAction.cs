using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction))]
    public partial interface IStagedOrderChangePaymentStateAction : IStagedOrderUpdateAction
    {
        IPaymentState PaymentState { get; set;}
    }
}
