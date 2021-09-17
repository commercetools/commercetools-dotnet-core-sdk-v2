using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class PaymentKeyReference : IPaymentKeyReference
    {
        public string Key { get; set; }

        public string TypeId { get; set; }
        public PaymentKeyReference()
        {
            this.TypeId = "payment";
        }
    }
}
