using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        List<IPaymentReference> Payments { get; set; }
    }
}
