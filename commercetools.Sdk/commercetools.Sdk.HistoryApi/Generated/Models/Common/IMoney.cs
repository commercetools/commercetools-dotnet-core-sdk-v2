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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Money))]
    public partial interface IMoney
    {
        string CurrencyCode { get; set; }

        int CentAmount { get; set; }

        int FractionDigits { get; set; }

        IMoneyType Type { get; set; }

    }
}
