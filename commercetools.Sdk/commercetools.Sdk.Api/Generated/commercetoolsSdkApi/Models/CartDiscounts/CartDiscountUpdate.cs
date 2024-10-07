using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountUpdate : ICartDiscountUpdate
    {
        public long Version { get; set; }

        public IList<ICartDiscountUpdateAction> Actions { get; set; }

        public IEnumerable<ICartDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
