using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreShippingPolicyUrlSetMessage))]
    public partial interface IStoreShippingPolicyUrlSetMessage : IMessage
    {
        string ShippingPolicyUrl { get; set; }

    }
}
