using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageSubscription))]
    public partial interface IMessageSubscription
    {
        IMessageSubscriptionResourceTypeId ResourceTypeId { get; set; }

        IList<string> Types { get; set; }
        IEnumerable<string> TypesEnumerable { set => Types = value.ToList(); }


    }
}
