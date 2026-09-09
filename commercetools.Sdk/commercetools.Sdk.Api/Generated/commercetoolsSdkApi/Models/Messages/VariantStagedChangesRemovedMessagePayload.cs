using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantStagedChangesRemovedMessagePayload : IVariantStagedChangesRemovedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public VariantStagedChangesRemovedMessagePayload()
        {
            this.Type = "VariantStagedChangesRemoved";
        }
    }
}
