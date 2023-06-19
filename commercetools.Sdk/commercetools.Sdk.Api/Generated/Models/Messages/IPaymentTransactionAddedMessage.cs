using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessage))]
    public partial interface IPaymentTransactionAddedMessage : IMessage
    {
        ITransaction Transaction { get; set; }

    }
}
