using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartDiscountCreatedMessagePayload : ICartDiscountCreatedMessagePayload
    {
        public string Type { get; set; }

        public ICartDiscount CartDiscount { get; set; }
        public CartDiscountCreatedMessagePayload()
        {
            this.Type = "CartDiscountCreated";
        }
    }
}
