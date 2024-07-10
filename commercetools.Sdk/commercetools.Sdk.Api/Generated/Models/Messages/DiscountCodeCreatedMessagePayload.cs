using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountCodeCreatedMessagePayload : IDiscountCodeCreatedMessagePayload
    {
        public string Type { get; set; }

        public IDiscountCode DiscountCode { get; set; }
        public DiscountCodeCreatedMessagePayload()
        {
            this.Type = "DiscountCodeCreated";
        }
    }
}
