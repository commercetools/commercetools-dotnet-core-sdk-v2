using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionUpdate : ISubscriptionUpdate
    {
        public long Version { get; set; }

        public IList<ISubscriptionUpdateAction> Actions { get; set; }
        public IEnumerable<ISubscriptionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
