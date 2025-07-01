using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessage))]
    public partial interface IPaymentMethodCustomTypeRemovedMessage : IMessage
    {
        string OldTypeId { get; set; }

    }
}
