

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantPublishedMessagePayload : IVariantPublishedMessagePayload
    {
        public string Type { get; set; }
        public VariantPublishedMessagePayload()
        {
            this.Type = "VariantPublished";
        }
    }
}
