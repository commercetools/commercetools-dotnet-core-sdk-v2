using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeAddFieldDefinitionAction))]
    public partial interface ITypeAddFieldDefinitionAction : ITypeUpdateAction
    {
        IFieldDefinition FieldDefinition { get; set;}
    }
}
