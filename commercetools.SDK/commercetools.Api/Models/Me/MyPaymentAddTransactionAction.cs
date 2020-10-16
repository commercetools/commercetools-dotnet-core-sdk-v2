using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addTransaction")]
    public partial class MyPaymentAddTransactionAction : MyPaymentUpdateAction
    {
        public TransactionDraft Transaction { get; set;}
        public MyPaymentAddTransactionAction()
        { 
           this.Action = "addTransaction";
        }
    }
}
