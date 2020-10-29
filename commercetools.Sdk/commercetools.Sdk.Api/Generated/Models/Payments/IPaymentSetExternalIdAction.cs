using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetExternalIdAction))]
    public interface IPaymentSetExternalIdAction : IPaymentUpdateAction
    {
        string ExternalId { get; set;}
    }
}
