using commercetools.Sdk.MLApi.Models.Common;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProduct : ISimilarProduct
    {
        public IProductReference Product { get; set; }

        public long? VariantId { get; set; }

        public ISimilarProductMeta Meta { get; set; }
    }
}
