using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction))]
    public partial interface IProductTypeAddAttributeDefinitionAction : IProductTypeUpdateAction
    {
        IAttributeDefinitionDraft Attribute { get; set;}
    }
}
