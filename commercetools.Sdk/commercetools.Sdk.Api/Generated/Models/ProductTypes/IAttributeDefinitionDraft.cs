using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeDefinitionDraft))]
    public partial interface IAttributeDefinitionDraft
    {
        IAttributeType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool IsRequired { get; set; }

        IAttributeConstraintEnum AttributeConstraint { get; set; }

        ILocalizedString InputTip { get; set; }

        ITextInputHint InputHint { get; set; }

        bool? IsSearchable { get; set; }

    }
}
