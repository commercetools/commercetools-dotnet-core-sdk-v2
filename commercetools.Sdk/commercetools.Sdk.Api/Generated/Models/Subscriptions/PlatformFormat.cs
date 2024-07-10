using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class PlatformFormat : IPlatformFormat
    {
        public string Type { get; set; }
        public PlatformFormat()
        {
            this.Type = "Platform";
        }
    }
}
