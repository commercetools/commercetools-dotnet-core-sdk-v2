using commercetools.Sdk.Api.Models.ProductSelections;


namespace commercetools.Sdk.Api.Models.Messages
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
