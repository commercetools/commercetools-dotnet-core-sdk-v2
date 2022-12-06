using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeChangeLocalizedEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<IAttributeLocalizedEnumValue> Values { get; set; }
        public IEnumerable<IAttributeLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public ProductTypeChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
