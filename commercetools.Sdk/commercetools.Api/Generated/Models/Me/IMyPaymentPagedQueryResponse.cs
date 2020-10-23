using commercetools.Api.Generated.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyPaymentPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IMyPayment> Results { get; set;}
    }
}
