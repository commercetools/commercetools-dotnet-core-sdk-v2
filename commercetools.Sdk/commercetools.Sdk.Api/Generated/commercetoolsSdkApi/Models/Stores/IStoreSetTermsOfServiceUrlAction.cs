using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetTermsOfServiceUrlAction))]
    public partial interface IStoreSetTermsOfServiceUrlAction : IStoreUpdateAction
    {
        string TermsOfServiceUrl { get; set; }

    }
}
