using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteValidToSetMessagePayload : IStagedQuoteValidToSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime ValidTo { get; set; }
        public StagedQuoteValidToSetMessagePayload()
        {
            this.Type = "StagedQuoteValidToSet";
        }
    }
}
