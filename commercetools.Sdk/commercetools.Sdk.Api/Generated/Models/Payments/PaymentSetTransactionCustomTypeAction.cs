using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetTransactionCustomTypeAction : IPaymentSetTransactionCustomTypeAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentSetTransactionCustomTypeAction()
        {
            this.Action = "setTransactionCustomType";
        }
    }
}
