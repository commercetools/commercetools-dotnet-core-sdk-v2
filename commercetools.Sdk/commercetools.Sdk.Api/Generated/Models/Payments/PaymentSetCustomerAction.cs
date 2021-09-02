using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetCustomerAction : IPaymentSetCustomerAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public PaymentSetCustomerAction()
        {
            this.Action = "setCustomer";
        }
    }
}
