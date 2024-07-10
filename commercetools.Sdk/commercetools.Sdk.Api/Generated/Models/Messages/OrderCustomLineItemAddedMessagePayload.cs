using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomLineItemAddedMessagePayload : IOrderCustomLineItemAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomLineItem CustomLineItem { get; set; }
        public OrderCustomLineItemAddedMessagePayload()
        {
            this.Type = "OrderCustomLineItemAdded";
        }
    }
}
