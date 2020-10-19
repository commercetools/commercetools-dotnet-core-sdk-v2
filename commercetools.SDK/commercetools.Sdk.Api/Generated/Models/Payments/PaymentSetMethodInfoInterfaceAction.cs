using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setMethodInfoInterface")]
    public partial class PaymentSetMethodInfoInterfaceAction : PaymentUpdateAction
    {
        public string Interface { get; set;}
        public PaymentSetMethodInfoInterfaceAction()
        { 
           this.Action = "setMethodInfoInterface";
        }
    }
}
