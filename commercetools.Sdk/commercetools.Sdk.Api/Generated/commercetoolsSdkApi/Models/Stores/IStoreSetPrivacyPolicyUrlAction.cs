using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetPrivacyPolicyUrlAction))]
    public partial interface IStoreSetPrivacyPolicyUrlAction : IStoreUpdateAction
    {
        string PrivacyPolicyUrl { get; set; }

    }
}
