using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCookiePolicyUrlAction))]
    public partial interface IStoreSetCookiePolicyUrlAction : IStoreUpdateAction
    {
        string CookiePolicyUrl { get; set; }

    }
}
