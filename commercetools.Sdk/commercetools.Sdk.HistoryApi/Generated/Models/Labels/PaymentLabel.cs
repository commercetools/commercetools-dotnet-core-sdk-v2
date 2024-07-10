using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class PaymentLabel : IPaymentLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public IMoney AmountPlanned { get; set; }
        public PaymentLabel()
        {
            this.Type = "PaymentLabel";
        }
    }
}
