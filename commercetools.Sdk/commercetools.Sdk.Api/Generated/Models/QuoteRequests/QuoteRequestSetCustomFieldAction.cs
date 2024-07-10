using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestSetCustomFieldAction : IQuoteRequestSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public QuoteRequestSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
