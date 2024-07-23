using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldLocalizedEnumType : ICustomFieldLocalizedEnumType
    {
        public string Name { get; set; }

        public IList<ICustomFieldLocalizedEnumValue> Values { get; set; }
        public IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public CustomFieldLocalizedEnumType()
        {
            this.Name = "LocalizedEnum";
        }
    }
}
