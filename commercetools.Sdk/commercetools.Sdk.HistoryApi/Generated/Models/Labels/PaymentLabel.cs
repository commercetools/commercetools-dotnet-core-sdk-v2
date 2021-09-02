using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
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
