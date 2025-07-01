using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoInterfaceAccountSetMessagePayload))]
    public partial interface IPaymentMethodInfoInterfaceAccountSetMessagePayload : IMessagePayload
    {
        string InterfaceAccount { get; set; }

        string OldInterfaceAccount { get; set; }

    }
}
