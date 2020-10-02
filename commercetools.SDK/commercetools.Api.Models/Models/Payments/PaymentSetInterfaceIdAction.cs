using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setInterfaceId")]
    public partial class PaymentSetInterfaceIdAction : PaymentUpdateAction
    {
        public string InterfaceId { get; set;}
        public PaymentSetInterfaceIdAction()
        { 
           this.Action = "setInterfaceId";
        }
    }
}
