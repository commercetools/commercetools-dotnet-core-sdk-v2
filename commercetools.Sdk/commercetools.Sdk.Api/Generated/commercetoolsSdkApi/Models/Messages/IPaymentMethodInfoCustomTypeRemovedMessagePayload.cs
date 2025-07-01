using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoCustomTypeRemovedMessagePayload))]
    public partial interface IPaymentMethodInfoCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string OldTypeId { get; set; }

    }
}
