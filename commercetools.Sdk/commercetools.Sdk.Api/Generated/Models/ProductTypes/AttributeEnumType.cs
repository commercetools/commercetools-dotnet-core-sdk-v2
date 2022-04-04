using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductTypes
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
