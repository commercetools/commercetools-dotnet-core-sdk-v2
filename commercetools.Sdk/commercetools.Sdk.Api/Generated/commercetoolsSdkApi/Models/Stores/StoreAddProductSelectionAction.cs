using commercetools.Sdk.Api.Models.ProductSelections;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreAddProductSelectionAction : IStoreAddProductSelectionAction
    {
        public string Action { get; set; }

        public IProductSelectionResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
        public StoreAddProductSelectionAction()
        {
            this.Action = "addProductSelection";
        }
    }
}
