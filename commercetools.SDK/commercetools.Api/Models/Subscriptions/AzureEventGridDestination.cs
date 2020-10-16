using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("EventGrid")]
    public partial class AzureEventGridDestination : Destination
    {
        public string Uri { get; set;}
        
        public string AccessKey { get; set;}
        public AzureEventGridDestination()
        { 
           this.Type = "EventGrid";
        }
    }
}
