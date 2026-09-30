

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeSavedToLineItemAction : IProductTypeChangeSavedToLineItemAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public bool SavedToLineItem { get; set; }
        public ProductTypeChangeSavedToLineItemAction()
        {
            this.Action = "changeSavedToLineItem";
        }
    }
}
