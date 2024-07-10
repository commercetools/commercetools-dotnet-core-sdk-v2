using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeUpdate : IDiscountCodeUpdate
    {
        public long Version { get; set; }

        public IList<IDiscountCodeUpdateAction> Actions { get; set; }
        public IEnumerable<IDiscountCodeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
