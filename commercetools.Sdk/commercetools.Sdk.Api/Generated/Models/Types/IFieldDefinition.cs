using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.FieldDefinition))]
    public partial interface IFieldDefinition
    {
        IFieldType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool Required { get; set; }

        ITypeTextInputHint InputHint { get; set; }

    }
}
