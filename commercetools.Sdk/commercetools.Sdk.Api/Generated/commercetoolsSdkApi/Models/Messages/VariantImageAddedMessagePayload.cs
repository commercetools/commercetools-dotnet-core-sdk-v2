using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantImageAddedMessagePayload : IVariantImageAddedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IImage Image { get; set; }

        public bool Staged { get; set; }
        public VariantImageAddedMessagePayload()
        {
            this.Type = "VariantImageAdded";
        }
    }
}
