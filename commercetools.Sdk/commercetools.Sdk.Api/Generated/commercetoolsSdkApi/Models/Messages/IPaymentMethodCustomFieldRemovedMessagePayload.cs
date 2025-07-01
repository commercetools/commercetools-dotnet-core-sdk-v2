using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessagePayload))]
    public partial interface IPaymentMethodCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
