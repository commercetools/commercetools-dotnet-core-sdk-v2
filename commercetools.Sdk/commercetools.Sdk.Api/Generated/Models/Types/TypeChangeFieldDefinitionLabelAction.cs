using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeChangeFieldDefinitionLabelAction : ITypeChangeFieldDefinitionLabelAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ILocalizedString Label { get; set; }
        public TypeChangeFieldDefinitionLabelAction()
        {
            this.Action = "changeFieldDefinitionLabel";
        }
    }
}
