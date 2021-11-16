using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeSetType))]
    public partial interface IAttributeSetType : IAttributeType
    {
        IAttributeType ElementType { get; set;}
    }
}
