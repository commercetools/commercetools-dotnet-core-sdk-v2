using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeLineItemsOrderAction : ICartChangeLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> LineItemOrder { get; set; }

        public IEnumerable<string> LineItemOrderEnumerable { set => LineItemOrder = value.ToList(); }
        public CartChangeLineItemsOrderAction()
        {
            this.Action = "changeLineItemsOrder";
        }
    }
}
