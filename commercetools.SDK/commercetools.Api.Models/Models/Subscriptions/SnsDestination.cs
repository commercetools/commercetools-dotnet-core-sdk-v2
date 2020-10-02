using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("SNS")]
    public partial class SnsDestination : Destination
    {
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        
        public string TopicArn { get; set;}
        public SnsDestination()
        { 
           this.Type = "SNS";
        }
    }
}
