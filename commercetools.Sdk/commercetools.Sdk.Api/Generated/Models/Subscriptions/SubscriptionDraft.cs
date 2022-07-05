using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionDraft : ISubscriptionDraft
    {
        public List<IChangeSubscription> Changes { get; set; }

        public IDestination Destination { get; set; }

        public string Key { get; set; }

        public List<IMessageSubscription> Messages { get; set; }

        public IDeliveryFormat Format { get; set; }
    }
}
