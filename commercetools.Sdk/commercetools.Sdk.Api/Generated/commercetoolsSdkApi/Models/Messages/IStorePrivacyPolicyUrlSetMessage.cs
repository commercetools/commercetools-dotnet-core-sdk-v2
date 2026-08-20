using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StorePrivacyPolicyUrlSetMessage))]
    public partial interface IStorePrivacyPolicyUrlSetMessage : IMessage
    {
        string PrivacyPolicyUrl { get; set; }

    }
}
