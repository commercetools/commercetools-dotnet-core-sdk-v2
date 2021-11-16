using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.MessageSubscription))]
    public partial interface IMessageSubscription 
    {
        string ResourceTypeId { get; set;}
        
        List<string> Types { get; set;}
    }
}
