using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public partial class SubscriptionSetChangesAction : ISubscriptionSetChangesAction
    {
        public string Action { get; set; }

        public List<IChangeSubscription> Changes { get; set; }
        public SubscriptionSetChangesAction()
        {
            this.Action = "setChanges";
        }
    }
}
