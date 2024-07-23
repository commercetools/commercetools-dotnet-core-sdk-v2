using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    public partial interface ISubscriptionSetChangesAction : ISubscriptionUpdateAction
    {
        IList<IChangeSubscription> Changes { get; set; }
        IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }


    }
}
