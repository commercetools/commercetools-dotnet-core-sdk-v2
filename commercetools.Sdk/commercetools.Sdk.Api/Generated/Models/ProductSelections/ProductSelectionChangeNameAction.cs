using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionChangeNameAction : IProductSelectionChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductSelectionChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
