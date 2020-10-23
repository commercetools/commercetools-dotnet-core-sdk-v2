using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public  partial class IronMqDestination : IIronMqDestination
    {
        public string Type { get; set;}
        
        public string Uri { get; set;}
        public IronMqDestination()
        { 
           this.Type = "IronMQ";
        }
    }
}
