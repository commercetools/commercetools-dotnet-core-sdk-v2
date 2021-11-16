using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldEnumType : ICustomFieldEnumType
    {
        public string Name { get; set;}
        
        public List<ICustomFieldEnumValue> Values { get; set;}
        public CustomFieldEnumType()
        { 
           this.Name = "Enum";
        }
    }
}
