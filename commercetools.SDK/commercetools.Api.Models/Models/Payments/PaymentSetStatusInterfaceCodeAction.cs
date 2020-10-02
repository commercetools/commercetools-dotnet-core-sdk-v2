using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setStatusInterfaceCode")]
    public partial class PaymentSetStatusInterfaceCodeAction : PaymentUpdateAction
    {
        public string InterfaceCode { get; set;}
        public PaymentSetStatusInterfaceCodeAction()
        { 
           this.Action = "setStatusInterfaceCode";
        }
    }
}
