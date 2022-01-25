namespace commercetools.Api.Models.Stores
{
    public partial class StoreAddProductSelectionAction : IStoreAddProductSelectionAction
    {
        public string Action { get; set; }

        public IProductSelectionSettingDraft ProductSelection { get; set; }
        public StoreAddProductSelectionAction()
        {
            this.Action = "addProductSelection";
        }
    }
}
