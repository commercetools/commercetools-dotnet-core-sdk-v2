using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantKeySetMessagePayload : IVariantKeySetMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public VariantKeySetMessagePayload()
        {
            this.Type = "VariantKeySet";
        }
    }
}
