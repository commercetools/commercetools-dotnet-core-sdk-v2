using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class MessageSubscription : IMessageSubscription
    {
        public IMessageSubscriptionResourceTypeId ResourceTypeId { get; set; }

        public IList<string> Types { get; set; }
        public IEnumerable<string> TypesEnumerable { set => Types = value.ToList(); }

    }
}
