using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeFieldDefinitionLabelAction))]
    public partial interface ITypeChangeFieldDefinitionLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ILocalizedString Label { get; set; }
    }
}
