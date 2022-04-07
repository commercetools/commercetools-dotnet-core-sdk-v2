using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.MLApi.Models.Common.Reference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.MLApi.Models.Common.CategoryReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.MLApi.Models.Common.ProductReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.MLApi.Models.Common.ProductTypeReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }
    }
}
