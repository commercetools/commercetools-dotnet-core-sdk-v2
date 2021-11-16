using commercetools.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProduct))]
    public partial interface ISimilarProduct 
    {
        IProductReference Product { get; set;}
        
        long? VariantId { get; set;}
        
        ISimilarProductMeta Meta { get; set;}
    }
}
