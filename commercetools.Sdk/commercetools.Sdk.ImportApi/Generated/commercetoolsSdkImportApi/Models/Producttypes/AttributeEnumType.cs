using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeEnumType : IAttributeEnumType
    {
        public string Name { get; set; }

        public IList<IAttributePlainEnumValue> Values { get; set; }

        public IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }
        public AttributeEnumType()
        {
            this.Name = "enum";
        }
    }
}
