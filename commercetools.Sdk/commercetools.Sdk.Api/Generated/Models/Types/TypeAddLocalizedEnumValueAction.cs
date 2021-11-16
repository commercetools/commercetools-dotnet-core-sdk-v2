namespace commercetools.Api.Models.Types
{
    public partial class TypeAddLocalizedEnumValueAction : ITypeAddLocalizedEnumValueAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        
        public ICustomFieldLocalizedEnumValue Value { get; set;}
        public TypeAddLocalizedEnumValueAction()
        { 
           this.Action = "addLocalizedEnumValue";
        }
    }
}
