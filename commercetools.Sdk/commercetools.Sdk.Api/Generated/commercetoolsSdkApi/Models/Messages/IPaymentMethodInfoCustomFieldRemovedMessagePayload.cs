using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessagePayload))]
    public partial interface IPaymentMethodInfoCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
