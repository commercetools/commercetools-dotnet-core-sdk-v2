using commercetools.Sdk.Api.Models.Categories;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductAddToCategoryAction : IProductAddToCategoryAction
    {
        public string Action { get; set; }

        public ICategoryResourceIdentifier Category { get; set; }

        public string OrderHint { get; set; }

        public bool? Staged { get; set; }
        public ProductAddToCategoryAction()
        {
            this.Action = "addToCategory";
        }
    }
}
