using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class SnsDestination : Destination
    {
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        
        public string TopicArn { get; set;}
    }
}
