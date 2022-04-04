using commercetools.Sdk.Api.Models.Categories;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class ProductRemovedFromCategoryMessagePayload : IProductRemovedFromCategoryMessagePayload
    {
        public string Type { get; set; }

        public ICategoryReference Category { get; set; }

        public bool Staged { get; set; }
        public ProductRemovedFromCategoryMessagePayload()
        {
            this.Type = "ProductRemovedFromCategory";
        }
    }
}
