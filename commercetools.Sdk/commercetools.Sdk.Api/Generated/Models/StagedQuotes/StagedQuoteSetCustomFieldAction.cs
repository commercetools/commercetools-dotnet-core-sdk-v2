using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteSetCustomFieldAction : IStagedQuoteSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedQuoteSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
