using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction))]
    public partial interface IStoreAddProductSelectionAction : IStoreUpdateAction
    {
        IProductSelectionSettingDraft ProductSelection { get; set; }
    }
}
