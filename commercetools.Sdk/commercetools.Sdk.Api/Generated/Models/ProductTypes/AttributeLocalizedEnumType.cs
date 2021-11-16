using System.Collections.Generic;


namespace commercetools.Api.Models.ProductTypes
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
