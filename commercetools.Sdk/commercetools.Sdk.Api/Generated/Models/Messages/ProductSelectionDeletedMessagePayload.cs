using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductSelectionDeletedMessagePayload : IProductSelectionDeletedMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductSelectionDeletedMessagePayload()
        {
            this.Type = "ProductSelectionDeleted";
        }
    }
}
