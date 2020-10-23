using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Subscriptions
{
    public interface ISubscriptionDelivery 
    {
        string ProjectKey { get; set;}
        
        string NotificationType { get; set;}
        
        IReference Resource { get; set;}
        
        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
