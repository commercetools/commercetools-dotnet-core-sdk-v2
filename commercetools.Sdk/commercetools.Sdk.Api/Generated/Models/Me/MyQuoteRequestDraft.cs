using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestDraft : IMyQuoteRequestDraft
    {
        public string CartId { get; set; }

        public long CartVersion { get; set; }

        public string Comment { get; set; }
    }
}
