using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeAttributeOrderByNameAction : IProductTypeChangeAttributeOrderByNameAction
    {
        public string Action { get; set; }

        public IList<string> AttributeNames { get; set; }

        public IEnumerable<string> AttributeNamesEnumerable { set => AttributeNames = value.ToList(); }
        public ProductTypeChangeAttributeOrderByNameAction()
        {
            this.Action = "changeAttributeOrderByName";
        }
    }
}
