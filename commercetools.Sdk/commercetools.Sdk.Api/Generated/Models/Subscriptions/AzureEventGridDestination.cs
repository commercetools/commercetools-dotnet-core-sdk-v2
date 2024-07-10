using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class AzureEventGridDestination : IAzureEventGridDestination
    {
        public string Type { get; set; }

        public string Uri { get; set; }

        public string AccessKey { get; set; }
        public AzureEventGridDestination()
        {
            this.Type = "EventGrid";
        }
    }
}
