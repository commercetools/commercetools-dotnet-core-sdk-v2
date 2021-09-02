using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
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
