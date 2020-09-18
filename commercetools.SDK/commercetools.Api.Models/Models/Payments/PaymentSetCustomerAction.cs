using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setCustomer")]
    public class PaymentSetCustomerAction : PaymentUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
    }
}
