using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetFaqUrlAction))]
    public partial interface IStoreSetFaqUrlAction : IStoreUpdateAction
    {
        string FaqUrl { get; set; }

    }
}
