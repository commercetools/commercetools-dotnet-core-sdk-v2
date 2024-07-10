using commercetools.Sdk.Api.Models.Categories;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRemoveFromCategoryAction : IProductRemoveFromCategoryAction
    {
        public string Action { get; set; }

        public ICategoryResourceIdentifier Category { get; set; }

        public bool? Staged { get; set; }
        public ProductRemoveFromCategoryAction()
        {
            this.Action = "removeFromCategory";
        }
    }
}
