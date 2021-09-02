using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentMethodInfo))]
    public partial interface IPaymentMethodInfo
    {
        string PaymentInterface { get; set; }

        string Method { get; set; }

        ILocalizedString Name { get; set; }
    }
}
