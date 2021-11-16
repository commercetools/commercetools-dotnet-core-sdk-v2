using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProductSearchRequestMeta))]
    public partial interface ISimilarProductSearchRequestMeta
    {
        ISimilarityMeasures SimilarityMeasures { get; set; }
    }
}
