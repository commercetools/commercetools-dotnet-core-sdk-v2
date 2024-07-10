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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveTextLineItemChange))]
    public partial interface IRemoveTextLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITextLineItem PreviousValue { get; set; }

        ITextLineItem NextValue { get; set; }

    }
}
