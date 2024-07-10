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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange))]
    public partial interface IChangeStackingModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IStackingMode PreviousValue { get; set; }

        IStackingMode NextValue { get; set; }

    }
}
