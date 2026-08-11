using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantUnpublishedMessagePayload : IVariantUnpublishedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public VariantUnpublishedMessagePayload()
        {
            this.Type = "VariantUnpublished";
        }
    }
}
