using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionDraft : ISubscriptionDraft
    {
        public IList<IChangeSubscription> Changes { get; set; }
        public IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }


        public IDestination Destination { get; set; }

        public string Key { get; set; }

        public IList<IMessageSubscription> Messages { get; set; }
        public IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }


        public IDeliveryFormat Format { get; set; }
    }
}
