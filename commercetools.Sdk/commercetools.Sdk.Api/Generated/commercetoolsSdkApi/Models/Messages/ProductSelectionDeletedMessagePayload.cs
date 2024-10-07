

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionDeletedMessagePayload : IProductSelectionDeletedMessagePayload
    {
        public string Type { get; set; }
        public ProductSelectionDeletedMessagePayload()
        {
            this.Type = "ProductSelectionDeleted";
        }
    }
}
