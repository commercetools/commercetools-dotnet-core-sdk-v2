using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreChangeProductSelectionAction : IStoreChangeProductSelectionAction
    {
        public string Action { get; set; }

        public IResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
        public StoreChangeProductSelectionAction()
        {
            this.Action = "changeProductSelectionActive";
        }
    }
}
