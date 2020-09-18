using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public class PayloadNotIncluded 
    {
        public string Reason { get; set;}
        
        public string PayloadType { get; set;}
    }
}
