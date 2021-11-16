using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionUpdate))]
    public partial interface ISubscriptionUpdate 
    {
        long Version { get; set;}
        
        List<ISubscriptionUpdateAction> Actions { get; set;}
    }
}
