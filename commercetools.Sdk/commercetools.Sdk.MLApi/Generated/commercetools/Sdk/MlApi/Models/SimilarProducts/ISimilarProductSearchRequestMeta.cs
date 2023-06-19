using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductSearchRequestMeta))]
    public partial interface ISimilarProductSearchRequestMeta
    {
        ISimilarityMeasures SimilarityMeasures { get; set; }

    }
}
