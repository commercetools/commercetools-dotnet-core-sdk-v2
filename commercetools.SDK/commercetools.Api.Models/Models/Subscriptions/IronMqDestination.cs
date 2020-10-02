using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("IronMQ")]
    public partial class IronMqDestination : Destination
    {
        public string Uri { get; set;}
        public IronMqDestination()
        { 
           this.Type = "IronMQ";
        }
    }
}
