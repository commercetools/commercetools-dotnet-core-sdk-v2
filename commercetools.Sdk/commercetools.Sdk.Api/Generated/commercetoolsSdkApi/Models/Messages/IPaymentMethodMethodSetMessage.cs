using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodMethodSetMessage))]
    public partial interface IPaymentMethodMethodSetMessage : IMessage
    {
        string Method { get; set; }

        string OldMethod { get; set; }

    }
}
