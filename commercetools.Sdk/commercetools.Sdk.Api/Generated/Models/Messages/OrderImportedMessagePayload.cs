using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderImportedMessagePayload : IOrderImportedMessagePayload
    {
        public string Type { get; set; }

        public IOrder Order { get; set; }
        public OrderImportedMessagePayload()
        {
            this.Type = "OrderImported";
        }
    }
}
