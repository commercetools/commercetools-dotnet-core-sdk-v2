using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("AzureServiceBus")]
    public class AzureServiceBusDestination : Destination
    {
        public string ConnectionString { get; set;}
    }
}
