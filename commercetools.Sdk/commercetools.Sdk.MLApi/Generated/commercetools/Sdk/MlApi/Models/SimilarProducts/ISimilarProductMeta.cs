using commercetools.Sdk.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductMeta))]
    public partial interface ISimilarProductMeta
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IMoney Price { get; set; }

        long? VariantCount { get; set; }

    }
}
