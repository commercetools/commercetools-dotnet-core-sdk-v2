using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetContactUrlAction))]
    public partial interface IStoreSetContactUrlAction : IStoreUpdateAction
    {
        string ContactUrl { get; set; }

    }
}
