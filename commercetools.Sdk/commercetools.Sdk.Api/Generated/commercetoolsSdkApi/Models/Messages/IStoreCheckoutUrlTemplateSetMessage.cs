using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCheckoutUrlTemplateSetMessage))]
    public partial interface IStoreCheckoutUrlTemplateSetMessage : IMessage
    {
        string CheckoutUrlTemplate { get; set; }

    }
}
