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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange))]
    public partial interface IChangePlainEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IEnumValue> PreviousValue { get; set; }
        IEnumerable<IEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IEnumValue> NextValue { get; set; }
        IEnumerable<IEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }


        string AttributeName { get; set; }

    }
}
