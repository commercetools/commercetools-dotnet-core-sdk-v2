using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantDeletedMessagePayload : IVariantDeletedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public VariantDeletedMessagePayload()
        {
            this.Type = "VariantDeleted";
        }
    }
}
