using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInterfaceAccountSetMessagePayload))]
    public partial interface IPaymentMethodInterfaceAccountSetMessagePayload : IMessagePayload
    {
        string InterfaceAccount { get; set; }

        string OldInterfaceAccount { get; set; }

    }
}
