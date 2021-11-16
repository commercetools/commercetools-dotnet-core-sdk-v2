using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.MLApi.Models.Common.Reference))]
    [SubTypeDiscriminator("category", typeof(commercetools.MLApi.Models.Common.CategoryReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.MLApi.Models.Common.ProductReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.MLApi.Models.Common.ProductTypeReference))]
    public partial interface IReference 
    {
        IReferenceTypeId TypeId { get; set;}
        
        string Id { get; set;}
    }
}
