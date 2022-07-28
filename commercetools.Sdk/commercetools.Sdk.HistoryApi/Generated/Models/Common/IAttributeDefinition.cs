using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.AttributeDefinition))]
    public partial interface IAttributeDefinition
    {
        IAttributeType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool IsRequired { get; set; }

        IAttributeConstraintEnum AttributeConstraint { get; set; }

        ILocalizedString InputTip { get; set; }

        ITextInputHint InputHint { get; set; }

        bool IsSearchable { get; set; }

    }
}
