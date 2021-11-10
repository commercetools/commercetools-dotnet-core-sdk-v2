using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderReturnInfoSetMessagePayload : IOrderReturnInfoSetMessagePayload
    {
        public string Type { get; set; }

        public List<IReturnInfo> ReturnInfo { get; set; }
        public OrderReturnInfoSetMessagePayload()
        {
            this.Type = "ReturnInfoSet";
        }
    }
}
