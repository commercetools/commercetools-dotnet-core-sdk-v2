using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetImprintUrlAction))]
    public partial interface IStoreSetImprintUrlAction : IStoreUpdateAction
    {
        string ImprintUrl { get; set; }

    }
}
