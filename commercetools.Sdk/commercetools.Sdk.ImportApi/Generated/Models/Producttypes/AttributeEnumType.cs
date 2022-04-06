using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    public partial class AttributeEnumType : IAttributeEnumType
    {
        public string Name { get; set; }

        public List<IAttributePlainEnumValue> Values { get; set; }
        public AttributeEnumType()
        {
            this.Name = "enum";
        }
    }
}
