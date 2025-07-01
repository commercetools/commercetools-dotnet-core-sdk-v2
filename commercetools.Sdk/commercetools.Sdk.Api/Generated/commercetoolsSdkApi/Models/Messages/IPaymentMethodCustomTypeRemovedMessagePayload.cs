using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCustomTypeRemovedMessagePayload))]
    public partial interface IPaymentMethodCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string OldTypeId { get; set; }

    }
}
