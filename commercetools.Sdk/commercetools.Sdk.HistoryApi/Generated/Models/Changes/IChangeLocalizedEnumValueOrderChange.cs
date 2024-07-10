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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange))]
    public partial interface IChangeLocalizedEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<ILocalizedEnumValue> PreviousValue { get; set; }
        IEnumerable<ILocalizedEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<ILocalizedEnumValue> NextValue { get; set; }
        IEnumerable<ILocalizedEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }


        string FieldName { get; set; }

        string AttributeName { get; set; }

    }
}
