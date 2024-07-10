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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTargetChange))]
    public partial interface IChangeTargetChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IChangeTargetChangeValue PreviousValue { get; set; }

        IChangeTargetChangeValue NextValue { get; set; }

    }
}
