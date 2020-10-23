using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyPaymentChangeAmountPlannedAction : IMyPaymentChangeAmountPlannedAction
    {
        public string Action { get; set;}
        
        public IMoney Amount { get; set;}
        public MyPaymentChangeAmountPlannedAction()
        { 
           this.Action = "changeAmountPlanned";
        }
    }
}
