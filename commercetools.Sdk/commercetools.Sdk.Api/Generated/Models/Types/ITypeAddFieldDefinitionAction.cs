using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeAddFieldDefinitionAction))]
    public partial interface ITypeAddFieldDefinitionAction : ITypeUpdateAction
    {
        IFieldDefinition FieldDefinition { get; set; }

    }
}
