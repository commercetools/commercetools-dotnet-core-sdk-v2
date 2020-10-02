using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("AzureServiceBus")]
    public partial class AzureServiceBusDestination : Destination
    {
        public string ConnectionString { get; set;}
        public AzureServiceBusDestination()
        { 
           this.Type = "AzureServiceBus";
        }
    }
}
