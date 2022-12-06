using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldEnumType : ICustomFieldEnumType
    {
        public string Name { get; set; }

        public IList<ICustomFieldEnumValue> Values { get; set; }
        public IEnumerable<ICustomFieldEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public CustomFieldEnumType()
        {
            this.Name = "Enum";
        }
    }
}
