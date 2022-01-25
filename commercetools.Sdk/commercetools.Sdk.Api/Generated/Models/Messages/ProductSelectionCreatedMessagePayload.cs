using commercetools.Api.Models.ProductSelections;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductSelectionCreatedMessagePayload : IProductSelectionCreatedMessagePayload
    {
        public string Type { get; set; }

        public IProductSelectionType ProductSelection { get; set; }
        public ProductSelectionCreatedMessagePayload()
        {
            this.Type = "ProductSelectionCreated";
        }
    }
}
