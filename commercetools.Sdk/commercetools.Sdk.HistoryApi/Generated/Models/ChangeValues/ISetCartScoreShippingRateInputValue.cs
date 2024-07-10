using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.SetCartScoreShippingRateInputValue))]
    public partial interface ISetCartScoreShippingRateInputValue
    {
        string Type { get; set; }

        int Score { get; set; }

    }
}
