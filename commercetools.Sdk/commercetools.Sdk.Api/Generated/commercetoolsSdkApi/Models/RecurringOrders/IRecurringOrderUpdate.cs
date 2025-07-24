using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderUpdate))]
    public partial interface IRecurringOrderUpdate
    {
        long Version { get; set; }

        IList<IRecurringOrderUpdateAction> Actions { get; set; }

        IEnumerable<IRecurringOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
