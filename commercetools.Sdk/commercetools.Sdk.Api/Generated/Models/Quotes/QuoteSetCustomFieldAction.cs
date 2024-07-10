using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteSetCustomFieldAction : IQuoteSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public QuoteSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
