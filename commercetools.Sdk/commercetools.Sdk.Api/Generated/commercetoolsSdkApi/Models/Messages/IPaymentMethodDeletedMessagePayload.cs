using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodDeletedMessagePayload))]
    public partial interface IPaymentMethodDeletedMessagePayload : IMessagePayload
    {
        IPaymentMethod PaymentMethod { get; set; }

    }
}
