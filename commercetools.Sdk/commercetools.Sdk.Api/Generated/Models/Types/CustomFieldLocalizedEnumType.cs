using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldLocalizedEnumType : ICustomFieldLocalizedEnumType
    {
        public string Name { get; set; }

        public List<ICustomFieldLocalizedEnumValue> Values { get; set; }
        public CustomFieldLocalizedEnumType()
        {
            this.Name = "LocalizedEnum";
        }
    }
}
