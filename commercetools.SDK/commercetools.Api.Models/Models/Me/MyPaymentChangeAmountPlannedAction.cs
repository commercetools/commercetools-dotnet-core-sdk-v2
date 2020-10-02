using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeAmountPlanned")]
    public partial class MyPaymentChangeAmountPlannedAction : MyPaymentUpdateAction
    {
        public Money Amount { get; set;}
        public MyPaymentChangeAmountPlannedAction()
        { 
           this.Action = "changeAmountPlanned";
        }
    }
}
