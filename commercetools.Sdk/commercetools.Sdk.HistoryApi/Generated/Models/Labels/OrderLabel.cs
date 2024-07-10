using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class OrderLabel : IOrderLabel
    {
        public string Type { get; set; }

        public string CustomerEmail { get; set; }

        public string OrderNumber { get; set; }
        public OrderLabel()
        {
            this.Type = "OrderLabel";
        }
    }
}
