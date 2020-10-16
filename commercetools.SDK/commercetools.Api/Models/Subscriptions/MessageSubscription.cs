using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class MessageSubscription 
    {
        public string ResourceTypeId { get; set;}
        
        public List<string> Types { get; set;}
    }
}
