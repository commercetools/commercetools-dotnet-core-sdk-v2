using commercetools.MLApi.Models.Common;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProduct : ISimilarProduct
    {
        public IProductReference Product { get; set; }

        public long? VariantId { get; set; }

        public ISimilarProductMeta Meta { get; set; }
    }
}
