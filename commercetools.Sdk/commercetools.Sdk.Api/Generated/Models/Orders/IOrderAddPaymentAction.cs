using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddPaymentAction))]
    public partial interface IOrderAddPaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
