using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setMethodInfoName")]
    public partial class PaymentSetMethodInfoNameAction : PaymentUpdateAction
    {
        public LocalizedString Name { get; set;}
        public PaymentSetMethodInfoNameAction()
        { 
           this.Action = "setMethodInfoName";
        }
    }
}
