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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemovePropertyChange))]
    public partial interface IRemovePropertyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        Object PreviousValue { get; set; }

        string Path { get; set; }

    }
}
