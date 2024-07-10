using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        IList<IReference> Payments { get; set; }
        IEnumerable<IReference> PaymentsEnumerable { set => Payments = value.ToList(); }


    }
}
