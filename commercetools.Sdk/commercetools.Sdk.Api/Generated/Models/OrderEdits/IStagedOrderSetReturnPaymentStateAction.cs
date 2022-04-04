using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction))]
    public partial interface IStagedOrderSetReturnPaymentStateAction : IStagedOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        IReturnPaymentState PaymentState { get; set; }
    }
}
