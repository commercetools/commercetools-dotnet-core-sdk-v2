using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction))]
    public partial interface IPaymentSetCustomerAction : IPaymentUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
