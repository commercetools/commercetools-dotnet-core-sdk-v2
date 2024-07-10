using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class HttpDestinationAuthentication : IHttpDestinationAuthentication
    {
        public string Type { get; set; }
    }
}
