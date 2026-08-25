using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreShippingPolicyUrlSetMessagePayload))]
    public partial interface IStoreShippingPolicyUrlSetMessagePayload : IMessagePayload
    {
        string ShippingPolicyUrl { get; set; }

    }
}
