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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionTimestampChange))]
    public partial interface IChangeTransactionTimestampChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

        ITransactionChangeValue Transaction { get; set; }

    }
}
