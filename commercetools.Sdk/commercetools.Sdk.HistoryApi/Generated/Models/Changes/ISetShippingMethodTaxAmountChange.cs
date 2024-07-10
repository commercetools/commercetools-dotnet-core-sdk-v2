using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange))]
    public partial interface ISetShippingMethodTaxAmountChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShippingMethodTaxAmountChangeValue PreviousValue { get; set; }

        IShippingMethodTaxAmountChangeValue NextValue { get; set; }

        ITaxMode TaxMode { get; set; }

    }
}
