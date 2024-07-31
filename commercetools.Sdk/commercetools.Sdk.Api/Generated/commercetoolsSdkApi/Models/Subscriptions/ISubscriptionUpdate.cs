using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionUpdate))]
    public partial interface ISubscriptionUpdate
    {
        long Version { get; set; }

        IList<ISubscriptionUpdateAction> Actions { get; set; }

        IEnumerable<ISubscriptionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
