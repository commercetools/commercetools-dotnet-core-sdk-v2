using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType))]
    public partial interface IAttributeSetType : IAttributeType
    {
        IAttributeType ElementType { get; set; }

    }
}
