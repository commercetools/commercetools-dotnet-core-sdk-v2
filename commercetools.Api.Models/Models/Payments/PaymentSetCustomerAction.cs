using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentSetCustomerAction : PaymentUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
    }
}
