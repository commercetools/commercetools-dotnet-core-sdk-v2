using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    public partial interface ITypeRemoveFieldDefinitionAction : ITypeUpdateAction
    {
        string FieldName { get; set; }
    }
}
