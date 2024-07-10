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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange))]
    public partial interface IChangeTransactionStateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITransactionState PreviousValue { get; set; }

        ITransactionState NextValue { get; set; }

        ITransactionChangeValue Transaction { get; set; }

    }
}
