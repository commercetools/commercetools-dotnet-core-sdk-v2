using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class PayloadNotIncluded : IPayloadNotIncluded
    {
        public string Reason { get; set;}
        
        public string PayloadType { get; set;}
    }
}
