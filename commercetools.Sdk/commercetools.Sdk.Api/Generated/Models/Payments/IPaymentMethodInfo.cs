using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentMethodInfo))]
    public partial interface IPaymentMethodInfo
    {
        string PaymentInterface { get; set; }

        string Method { get; set; }

        ILocalizedString Name { get; set; }

    }
}
