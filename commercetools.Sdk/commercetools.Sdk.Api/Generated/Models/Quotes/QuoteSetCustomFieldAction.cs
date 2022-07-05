using System;


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
