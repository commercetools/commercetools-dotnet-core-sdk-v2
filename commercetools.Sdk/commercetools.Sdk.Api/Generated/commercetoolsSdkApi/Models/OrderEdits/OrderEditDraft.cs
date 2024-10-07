using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditDraft : IOrderEditDraft
    {
        public string Key { get; set; }

        public IOrderReference Resource { get; set; }

        public IList<IStagedOrderUpdateAction> StagedActions { get; set; }

        public IEnumerable<IStagedOrderUpdateAction> StagedActionsEnumerable { set => StagedActions = value.ToList(); }

        public ICustomFieldsDraft Custom { get; set; }

        public string Comment { get; set; }

        public bool? DryRun { get; set; }
    }
}
