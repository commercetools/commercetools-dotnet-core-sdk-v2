using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessage))]
    public partial interface IPaymentMethodInfoInterfaceAccountSetMessage : IMessage
    {
        string InterfaceAccount { get; set; }

        string OldInterfaceAccount { get; set; }

    }
}
