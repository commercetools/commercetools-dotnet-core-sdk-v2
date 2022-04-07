using commercetools.Sdk.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProduct))]
    public partial interface ISimilarProduct
    {
        IProductReference Product { get; set; }

        long? VariantId { get; set; }

        ISimilarProductMeta Meta { get; set; }
    }
}
