using System;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteSetValidToAction : IStagedQuoteSetValidToAction
    {
        public string Action { get; set; }

        public DateTime? ValidTo { get; set; }
        public StagedQuoteSetValidToAction()
        {
            this.Action = "setValidTo";
        }
    }
}
