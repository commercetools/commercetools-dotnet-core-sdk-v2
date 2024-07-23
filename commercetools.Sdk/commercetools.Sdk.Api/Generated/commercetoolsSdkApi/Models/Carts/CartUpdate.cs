using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartUpdate : ICartUpdate
    {
        public long Version { get; set; }

        public IList<ICartUpdateAction> Actions { get; set; }
        public IEnumerable<ICartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
