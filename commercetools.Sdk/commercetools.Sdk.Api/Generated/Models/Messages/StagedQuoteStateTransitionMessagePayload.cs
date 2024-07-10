using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteStateTransitionMessagePayload : IStagedQuoteStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public IStateReference OldState { get; set; }

        public bool Force { get; set; }
        public StagedQuoteStateTransitionMessagePayload()
        {
            this.Type = "StagedQuoteStateTransition";
        }
    }
}
