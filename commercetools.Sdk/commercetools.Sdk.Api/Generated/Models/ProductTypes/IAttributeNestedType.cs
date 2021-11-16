using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeNestedType))]
    public partial interface IAttributeNestedType : IAttributeType
    {
        IProductTypeReference TypeReference { get; set;}
    }
}
