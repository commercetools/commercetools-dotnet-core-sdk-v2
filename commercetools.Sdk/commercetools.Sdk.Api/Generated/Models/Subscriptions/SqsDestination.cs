using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SqsDestination : ISqsDestination
    {
        public string Type { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        
        public string QueueUrl { get; set;}
        
        public string Region { get; set;}
        public SqsDestination()
        { 
           this.Type = "SQS";
        }
    }
}
