using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessage))]
    public partial interface IPaymentMethodInterfaceAccountSetMessage : IMessage
    {
        string InterfaceAccount { get; set; }

        string OldInterfaceAccount { get; set; }

    }
}
