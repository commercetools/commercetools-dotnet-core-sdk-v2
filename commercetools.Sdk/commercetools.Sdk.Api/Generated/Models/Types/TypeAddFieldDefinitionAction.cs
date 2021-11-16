namespace commercetools.Api.Models.Types
{
    public partial class TypeAddFieldDefinitionAction : ITypeAddFieldDefinitionAction
    {
        public string Action { get; set; }

        public IFieldDefinition FieldDefinition { get; set; }
        public TypeAddFieldDefinitionAction()
        {
            this.Action = "addFieldDefinition";
        }
    }
}
