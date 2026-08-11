using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.VariantAttributes
{

    public partial class VariantAttributesAttributeMetadata : IVariantAttributesAttributeMetadata
    {
        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public string Type { get; set; }
    }
}
