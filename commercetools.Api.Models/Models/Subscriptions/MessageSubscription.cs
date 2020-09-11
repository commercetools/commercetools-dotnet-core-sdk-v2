using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class MessageSubscription 
    {
        public string ResourceTypeId { get; set;}
        
        public List<string> Types { get; set;}
    }
}
