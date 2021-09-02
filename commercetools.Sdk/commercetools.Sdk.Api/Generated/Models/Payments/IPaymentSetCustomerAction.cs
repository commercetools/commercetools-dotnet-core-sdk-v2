using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetCustomerAction))]
    public partial interface IPaymentSetCustomerAction : IPaymentUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }
    }
}
