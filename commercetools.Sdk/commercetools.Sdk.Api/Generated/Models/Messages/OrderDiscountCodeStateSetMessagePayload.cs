using commercetools.Sdk.Api.Models.Carts;
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

    public partial class OrderDiscountCodeStateSetMessagePayload : IOrderDiscountCodeStateSetMessagePayload
    {
        public string Type { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }

        public IDiscountCodeState OldState { get; set; }
        public OrderDiscountCodeStateSetMessagePayload()
        {
            this.Type = "OrderDiscountCodeStateSet";
        }
    }
}
