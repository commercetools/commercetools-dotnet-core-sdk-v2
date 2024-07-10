using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType))]
    public partial interface IAttributeNestedType : IAttributeType
    {
        IProductTypeReference TypeReference { get; set; }

    }
}
