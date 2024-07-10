using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class ConfluentCloudDestination : IConfluentCloudDestination
    {
        public string Type { get; set; }

        public string BootstrapServer { get; set; }

        public string ApiKey { get; set; }

        public string ApiSecret { get; set; }

        public string Acks { get; set; }

        public string Topic { get; set; }

        public string Key { get; set; }
        public ConfluentCloudDestination()
        {
            this.Type = "ConfluentCloud";
        }
    }
}
