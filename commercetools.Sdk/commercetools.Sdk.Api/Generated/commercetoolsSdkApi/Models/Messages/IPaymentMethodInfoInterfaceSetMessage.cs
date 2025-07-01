using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceSetMessage))]
    public partial interface IPaymentMethodInfoInterfaceSetMessage : IMessage
    {
        string Interface { get; set; }

        string OldInterface { get; set; }

    }
}
