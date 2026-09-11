

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantSkuSetMessagePayload : IVariantSkuSetMessagePayload
    {
        public string Type { get; set; }

        public string Sku { get; set; }

        public string OldSku { get; set; }

        public bool Staged { get; set; }
        public VariantSkuSetMessagePayload()
        {
            this.Type = "VariantSkuSet";
        }
    }
}
