using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyPaymentAddTransactionAction : IMyPaymentAddTransactionAction
    {
        public string Action { get; set;}
        
        public ITransactionDraft Transaction { get; set;}
        public MyPaymentAddTransactionAction()
        { 
           this.Action = "addTransaction";
        }
    }
}
