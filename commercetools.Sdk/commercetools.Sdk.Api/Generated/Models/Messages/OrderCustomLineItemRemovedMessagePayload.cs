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

    public partial class OrderCustomLineItemRemovedMessagePayload : IOrderCustomLineItemRemovedMessagePayload
    {
        public string Type { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public ICustomLineItem CustomLineItem { get; set; }
        public OrderCustomLineItemRemovedMessagePayload()
        {
            this.Type = "OrderCustomLineItemRemoved";
        }
    }
}
