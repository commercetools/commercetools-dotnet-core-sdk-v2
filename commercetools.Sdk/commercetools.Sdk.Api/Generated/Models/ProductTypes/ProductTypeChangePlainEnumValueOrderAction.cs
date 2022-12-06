using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueOrderAction : IProductTypeChangePlainEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<IAttributePlainEnumValue> Values { get; set; }
        public IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public ProductTypeChangePlainEnumValueOrderAction()
        {
            this.Action = "changePlainEnumValueOrder";
        }
    }
}
