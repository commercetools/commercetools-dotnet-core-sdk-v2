namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionSetKeyAction : IProductSelectionSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductSelectionSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
