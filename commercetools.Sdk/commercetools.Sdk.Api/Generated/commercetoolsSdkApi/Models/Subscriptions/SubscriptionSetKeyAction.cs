

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetKeyAction : ISubscriptionSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public SubscriptionSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
