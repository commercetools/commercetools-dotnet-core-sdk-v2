using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Subscriptions
{
    public interface IMessageSubscription 
    {
        string ResourceTypeId { get; set;}
        
        List<string> Types { get; set;}
    }
}
