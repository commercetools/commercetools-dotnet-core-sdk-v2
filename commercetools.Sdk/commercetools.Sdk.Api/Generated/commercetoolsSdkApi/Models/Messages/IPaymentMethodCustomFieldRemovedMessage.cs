using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomFieldRemovedMessage))]
    public partial interface IPaymentMethodCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
