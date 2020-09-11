using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class AzureServiceBusDestination : Destination
    {
        public string ConnectionString { get; set;}
    }
}
