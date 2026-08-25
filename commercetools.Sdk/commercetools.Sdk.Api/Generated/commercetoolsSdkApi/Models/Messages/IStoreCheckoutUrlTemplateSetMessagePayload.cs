using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCheckoutUrlTemplateSetMessagePayload))]
    public partial interface IStoreCheckoutUrlTemplateSetMessagePayload : IMessagePayload
    {
        string CheckoutUrlTemplate { get; set; }

    }
}
