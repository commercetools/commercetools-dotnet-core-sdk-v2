using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionSetCustomFieldAction : IProductSelectionSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ProductSelectionSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
