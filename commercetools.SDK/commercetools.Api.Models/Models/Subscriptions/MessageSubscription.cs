using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public class MessageSubscription 
    {
        public string ResourceTypeId { get; set;}
        
        public List<string> Types { get; set;}
    }
}
