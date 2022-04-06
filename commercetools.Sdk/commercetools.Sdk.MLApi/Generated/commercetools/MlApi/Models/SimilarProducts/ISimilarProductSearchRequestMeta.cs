using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductSearchRequestMeta))]
    public partial interface ISimilarProductSearchRequestMeta
    {
        ISimilarityMeasures SimilarityMeasures { get; set; }
    }
}
