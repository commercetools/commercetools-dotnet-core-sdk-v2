using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoMethodAction))]
    public partial interface IPaymentSetMethodInfoMethodAction : IPaymentUpdateAction
    {
        string Method { get; set; }
    }
}
