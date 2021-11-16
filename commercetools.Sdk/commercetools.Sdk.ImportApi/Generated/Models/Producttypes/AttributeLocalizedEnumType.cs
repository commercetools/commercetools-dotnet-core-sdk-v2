using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeLocalizedEnumType : IAttributeLocalizedEnumType
    {
        public string Name { get; set; }

        public List<IAttributeLocalizedEnumValue> Values { get; set; }
        public AttributeLocalizedEnumType()
        {
            this.Name = "lenum";
        }
    }
}
