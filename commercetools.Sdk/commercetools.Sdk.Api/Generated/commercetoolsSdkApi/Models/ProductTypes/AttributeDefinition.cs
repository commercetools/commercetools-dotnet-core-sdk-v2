using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeDefinition : IAttributeDefinition
    {
        public IAttributeType Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public bool IsRequired { get; set; }

        public IAttributeLevelEnum Level { get; set; }

        public IAttributeConstraintEnum AttributeConstraint { get; set; }

        public ILocalizedString InputTip { get; set; }

        public ITextInputHint InputHint { get; set; }

        public bool IsSearchable { get; set; }
    }
}
