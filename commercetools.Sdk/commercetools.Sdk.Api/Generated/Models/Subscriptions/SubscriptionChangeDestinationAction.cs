namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionChangeDestinationAction : ISubscriptionChangeDestinationAction
    {
        public string Action { get; set; }

        [System.Obsolete]
        public IDestination Destination { get; set; }
        public SubscriptionChangeDestinationAction()
        {
            this.Action = "changeDestination";
        }
    }
}
