using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StorePrivacyPolicyUrlSetMessagePayload))]
    public partial interface IStorePrivacyPolicyUrlSetMessagePayload : IMessagePayload
    {
        string PrivacyPolicyUrl { get; set; }

    }
}
