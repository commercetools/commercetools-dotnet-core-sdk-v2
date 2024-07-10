using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountCodeKeySetMessagePayload : IDiscountCodeKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public DiscountCodeKeySetMessagePayload()
        {
            this.Type = "DiscountCodeKeySet";
        }
    }
}
