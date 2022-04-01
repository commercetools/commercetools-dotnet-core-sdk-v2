using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeFieldDefinitionLabelAction))]
    public partial interface ITypeChangeFieldDefinitionLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ILocalizedString Label { get; set; }
    }
}
