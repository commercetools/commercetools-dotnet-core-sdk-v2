using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutMessagePaymentsPayloadBaseData))]
    public partial interface ICheckoutMessagePaymentsPayloadBaseData
    {
        string ProjectKey { get; set; }

        IPaymentReference Payment { get; set; }

        string TransactionId { get; set; }

        ICartReference Cart { get; set; }

        IOrderReference Order { get; set; }

    }
}
