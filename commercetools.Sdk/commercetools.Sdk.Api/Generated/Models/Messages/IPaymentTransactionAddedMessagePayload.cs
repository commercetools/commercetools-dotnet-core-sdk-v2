using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionAddedMessagePayload))]
    public partial interface IPaymentTransactionAddedMessagePayload : IMessagePayload
    {
        ITransaction Transaction { get; set; }

    }
}
