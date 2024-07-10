using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteTransitionStateAction : IQuoteTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public QuoteTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
