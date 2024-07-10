using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderEditAppliedMessagePayload : IOrderEditAppliedMessagePayload
    {
        public string Type { get; set; }

        public IOrderEdit Edit { get; set; }

        public IOrderEditApplied Result { get; set; }
        public OrderEditAppliedMessagePayload()
        {
            this.Type = "OrderEditApplied";
        }
    }
}
