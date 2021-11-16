using commercetools.Api.Models.Categories;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductAddedToCategoryMessagePayload : IProductAddedToCategoryMessagePayload
    {
        public string Type { get; set;}
        
        public ICategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductAddedToCategoryMessagePayload()
        { 
           this.Type = "ProductAddedToCategory";
        }
    }
}
