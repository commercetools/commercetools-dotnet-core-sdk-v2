using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    public partial interface ITypeRemoveFieldDefinitionAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

    }
}
