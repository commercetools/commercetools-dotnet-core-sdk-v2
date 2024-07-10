using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionUpdate))]
    public partial interface ISubscriptionUpdate
    {
        long Version { get; set; }

        IList<ISubscriptionUpdateAction> Actions { get; set; }
        IEnumerable<ISubscriptionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
