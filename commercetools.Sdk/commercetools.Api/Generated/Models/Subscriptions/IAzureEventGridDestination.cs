using commercetools.Api.Generated.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Subscriptions
{
    public interface IAzureEventGridDestination : IDestination
    {
        string Uri { get; set;}
        
        string AccessKey { get; set;}
    }
}
