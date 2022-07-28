using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction))]
    public partial interface IStagedOrderAddPaymentAction : IStagedOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
