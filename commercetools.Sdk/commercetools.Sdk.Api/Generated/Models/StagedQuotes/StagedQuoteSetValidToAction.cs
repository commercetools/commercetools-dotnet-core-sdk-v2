using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
