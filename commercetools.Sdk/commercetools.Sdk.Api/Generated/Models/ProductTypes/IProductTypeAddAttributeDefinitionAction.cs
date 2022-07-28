using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction))]
    public partial interface IProductTypeAddAttributeDefinitionAction : IProductTypeUpdateAction
    {
        IAttributeDefinitionDraft Attribute { get; set; }

    }
}
