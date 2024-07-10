using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange))]
    public partial interface ISetShippingMethodChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShippingMethodChangeValue PreviousValue { get; set; }

        IShippingMethodChangeValue NextValue { get; set; }

    }
}
