using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setCustomer")]
    public partial class PaymentSetCustomerAction : PaymentUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
        public PaymentSetCustomerAction()
        { 
           this.Action = "setCustomer";
        }
    }
}
