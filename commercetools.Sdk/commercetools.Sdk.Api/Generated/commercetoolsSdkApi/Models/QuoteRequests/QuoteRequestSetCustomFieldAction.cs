using System;

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
