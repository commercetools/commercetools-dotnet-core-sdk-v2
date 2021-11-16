namespace commercetools.Api.Models.Types
{
    public partial class TypeRemoveFieldDefinitionAction : ITypeRemoveFieldDefinitionAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        public TypeRemoveFieldDefinitionAction()
        { 
           this.Action = "removeFieldDefinition";
        }
    }
}
