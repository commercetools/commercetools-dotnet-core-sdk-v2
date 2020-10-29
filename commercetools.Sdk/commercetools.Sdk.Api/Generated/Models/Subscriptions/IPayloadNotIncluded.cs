using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.PayloadNotIncluded))]
    public interface IPayloadNotIncluded 
    {
        string Reason { get; set;}
        
        string PayloadType { get; set;}
    }
}
