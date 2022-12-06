using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionDraft))]
    public partial interface ISubscriptionDraft
    {
        IList<IChangeSubscription> Changes { get; set; }
        IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }


        IDestination Destination { get; set; }

        string Key { get; set; }

        IList<IMessageSubscription> Messages { get; set; }
        IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }


        IDeliveryFormat Format { get; set; }

    }
}
