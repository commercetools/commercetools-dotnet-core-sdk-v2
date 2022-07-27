namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeLocalizedEnumValueLabelAction : ITypeChangeLocalizedEnumValueLabelAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ICustomFieldLocalizedEnumValue Value { get; set; }
        public TypeChangeLocalizedEnumValueLabelAction()
        {
            this.Action = "changeLocalizedEnumValueLabel";
        }
    }
}
