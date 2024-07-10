using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceValueChangedMessagePayload : IStandalonePriceValueChangedMessagePayload
    {
        public string Type { get; set; }

        public ITypedMoney Value { get; set; }

        public bool Staged { get; set; }

        public ITypedMoney OldValue { get; set; }
        public StandalonePriceValueChangedMessagePayload()
        {
            this.Type = "StandalonePriceValueChanged";
        }
    }
}
