using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeRemoveEnumValuesAction : IProductTypeRemoveEnumValuesAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<string> Keys { get; set; }

        public IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }
        public ProductTypeRemoveEnumValuesAction()
        {
            this.Action = "removeEnumValues";
        }
    }
}
