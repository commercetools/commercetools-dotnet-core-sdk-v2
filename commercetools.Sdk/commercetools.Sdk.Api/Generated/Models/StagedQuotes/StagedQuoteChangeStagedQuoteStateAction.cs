using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteChangeStagedQuoteStateAction : IStagedQuoteChangeStagedQuoteStateAction
    {
        public string Action { get; set; }

        public IStagedQuoteState StagedQuoteState { get; set; }
        public StagedQuoteChangeStagedQuoteStateAction()
        {
            this.Action = "changeStagedQuoteState";
        }
    }
}
