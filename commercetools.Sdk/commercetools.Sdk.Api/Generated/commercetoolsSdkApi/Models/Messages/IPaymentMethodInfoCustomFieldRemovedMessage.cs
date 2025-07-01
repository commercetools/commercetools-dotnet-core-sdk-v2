using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomFieldRemovedMessage))]
    public partial interface IPaymentMethodInfoCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
