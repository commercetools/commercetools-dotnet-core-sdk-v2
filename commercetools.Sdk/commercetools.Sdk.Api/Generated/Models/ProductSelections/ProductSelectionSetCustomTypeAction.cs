using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionSetCustomTypeAction : IProductSelectionSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ProductSelectionSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
