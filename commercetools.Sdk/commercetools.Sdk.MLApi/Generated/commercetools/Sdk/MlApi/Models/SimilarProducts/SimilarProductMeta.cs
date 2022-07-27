using commercetools.Sdk.MLApi.Models.Common;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductMeta : ISimilarProductMeta
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IMoney Price { get; set; }

        public long? VariantCount { get; set; }
    }
}
