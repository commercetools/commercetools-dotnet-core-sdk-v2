using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction))]
    public partial interface IPaymentSetMethodInfoNameAction : IPaymentUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
