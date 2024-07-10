using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        IList<IPaymentReference> Payments { get; set; }
        IEnumerable<IPaymentReference> PaymentsEnumerable { set => Payments = value.ToList(); }


    }
}
