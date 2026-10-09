

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeSetSavedToLineItemAction : IProductTypeSetSavedToLineItemAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public bool SavedToLineItem { get; set; }
        public ProductTypeSetSavedToLineItemAction()
        {
            this.Action = "setSavedToLineItem";
        }
    }
}
