using commercetools.Api.Models.Categories;


namespace commercetools.Api.Models.Messages
{
    public partial class CategoryCreatedMessagePayload : ICategoryCreatedMessagePayload
    {
        public string Type { get; set; }

        public ICategory Category { get; set; }
        public CategoryCreatedMessagePayload()
        {
            this.Type = "CategoryCreated";
        }
    }
}
