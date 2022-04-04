using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction))]
    public partial interface IOrderRemovePaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
