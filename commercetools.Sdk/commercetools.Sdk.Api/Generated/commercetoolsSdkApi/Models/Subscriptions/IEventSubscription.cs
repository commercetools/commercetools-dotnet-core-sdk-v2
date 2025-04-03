using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.EventSubscription))]
    public partial interface IEventSubscription
    {
        IEventSubscriptionResourceTypeId ResourceTypeId { get; set; }

        IList<IEventType> Types { get; set; }

        IEnumerable<IEventType> TypesEnumerable { set => Types = value.ToList(); }

    }
}
