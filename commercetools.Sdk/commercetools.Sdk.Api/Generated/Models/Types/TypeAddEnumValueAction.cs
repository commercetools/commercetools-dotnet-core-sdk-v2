namespace commercetools.Api.Models.Types
{
    public partial class TypeAddEnumValueAction : ITypeAddEnumValueAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        
        public ICustomFieldEnumValue Value { get; set;}
        public TypeAddEnumValueAction()
        { 
           this.Action = "addEnumValue";
        }
    }
}
