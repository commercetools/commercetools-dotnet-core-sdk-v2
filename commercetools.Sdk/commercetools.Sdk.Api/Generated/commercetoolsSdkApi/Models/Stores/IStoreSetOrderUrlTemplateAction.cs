using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetOrderUrlTemplateAction))]
    public partial interface IStoreSetOrderUrlTemplateAction : IStoreUpdateAction
    {
        string OrderUrlTemplate { get; set; }

    }
}
