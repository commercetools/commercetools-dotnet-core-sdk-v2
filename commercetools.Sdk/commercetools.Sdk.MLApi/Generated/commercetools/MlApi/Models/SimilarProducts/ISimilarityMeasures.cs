using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarityMeasures))]
    public partial interface ISimilarityMeasures 
    {
        long? Name { get; set;}
        
        long? Description { get; set;}
        
        long? Attribute { get; set;}
        
        long? VariantCount { get; set;}
        
        long? Price { get; set;}
    }
}
