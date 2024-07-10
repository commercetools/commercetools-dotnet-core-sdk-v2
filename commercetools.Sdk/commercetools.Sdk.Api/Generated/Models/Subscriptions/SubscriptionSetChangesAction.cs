using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetChangesAction : ISubscriptionSetChangesAction
    {
        public string Action { get; set; }

        public IList<IChangeSubscription> Changes { get; set; }
        public IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }

        public SubscriptionSetChangesAction()
        {
            this.Action = "setChanges";
        }
    }
}
