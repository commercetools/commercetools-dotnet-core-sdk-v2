namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionChangeDestinationAction : ISubscriptionChangeDestinationAction
    {
        public string Action { get; set; }

        public IDestination Destination { get; set; }
        public SubscriptionChangeDestinationAction()
        {
            this.Action = "changeDestination";
        }
    }
}
