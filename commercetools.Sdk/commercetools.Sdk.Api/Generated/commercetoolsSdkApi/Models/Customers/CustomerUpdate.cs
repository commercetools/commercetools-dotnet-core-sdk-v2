using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerUpdate : ICustomerUpdate
    {
        public long Version { get; set; }

        public IList<ICustomerUpdateAction> Actions { get; set; }

        public IEnumerable<ICustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
