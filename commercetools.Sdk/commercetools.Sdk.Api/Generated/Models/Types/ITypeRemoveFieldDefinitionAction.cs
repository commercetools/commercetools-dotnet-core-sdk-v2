using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    public partial interface ITypeRemoveFieldDefinitionAction : ITypeUpdateAction
    {
        string FieldName { get; set;}
    }
}
