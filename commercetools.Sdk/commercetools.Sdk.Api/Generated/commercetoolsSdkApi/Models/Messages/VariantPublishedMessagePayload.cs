using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantPublishedMessagePayload : IVariantPublishedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public VariantPublishedMessagePayload()
        {
            this.Type = "VariantPublished";
        }
    }
}
