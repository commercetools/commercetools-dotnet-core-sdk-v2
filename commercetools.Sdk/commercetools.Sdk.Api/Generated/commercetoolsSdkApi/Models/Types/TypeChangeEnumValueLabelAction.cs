

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeEnumValueLabelAction : ITypeChangeEnumValueLabelAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ICustomFieldEnumValue Value { get; set; }
        public TypeChangeEnumValueLabelAction()
        {
            this.Action = "changeEnumValueLabel";
        }
    }
}
