using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class CloudEventsFormat : ICloudEventsFormat
    {
        public string Type { get; set; }

        public string CloudEventsVersion { get; set; }
        public CloudEventsFormat()
        {
            this.Type = "CloudEvents";
        }
    }
}
