using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderRemovePaymentAction))]
    public partial interface IOrderRemovePaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
