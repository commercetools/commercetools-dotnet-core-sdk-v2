using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceActiveChangedMessagePayload : IStandalonePriceActiveChangedMessagePayload
    {
        public string Type { get; set; }

        public bool Active { get; set; }

        public bool OldActive { get; set; }
        public StandalonePriceActiveChangedMessagePayload()
        {
            this.Type = "StandalonePriceActiveChanged";
        }
    }
}
