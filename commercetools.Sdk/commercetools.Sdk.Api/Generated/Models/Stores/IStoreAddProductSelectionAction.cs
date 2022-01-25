using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreAddProductSelectionAction))]
    public partial interface IStoreAddProductSelectionAction : IStoreUpdateAction
    {
        IProductSelectionSettingDraft ProductSelection { get; set; }
    }
}
