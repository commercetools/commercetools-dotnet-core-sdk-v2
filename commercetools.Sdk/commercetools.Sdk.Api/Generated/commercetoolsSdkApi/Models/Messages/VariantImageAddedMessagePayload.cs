using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantImageAddedMessagePayload : IVariantImageAddedMessagePayload
    {
        public string Type { get; set; }

        public IImage Image { get; set; }

        public bool Staged { get; set; }
        public VariantImageAddedMessagePayload()
        {
            this.Type = "VariantImageAdded";
        }
    }
}
