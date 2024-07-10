using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction))]
    public partial interface IProductTypeRemoveAttributeDefinitionAction : IProductTypeUpdateAction
    {
        string Name { get; set; }

    }
}
