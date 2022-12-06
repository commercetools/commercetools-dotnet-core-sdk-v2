using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionUpdate))]
    public partial interface ISubscriptionUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ISubscriptionUpdate, ISubscriptionUpdateAction>
    {
        new long Version { get; set; }
        new IList<ISubscriptionUpdateAction> Actions { get; set; }
        IEnumerable<ISubscriptionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
