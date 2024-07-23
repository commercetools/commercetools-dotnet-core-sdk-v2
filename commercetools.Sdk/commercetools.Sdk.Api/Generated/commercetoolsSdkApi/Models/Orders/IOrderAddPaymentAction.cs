using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddPaymentAction))]
    public partial interface IOrderAddPaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
