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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange))]
    public partial interface ISetCountriesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IStoreCountry> PreviousValue { get; set; }
        IEnumerable<IStoreCountry> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IStoreCountry> NextValue { get; set; }
        IEnumerable<IStoreCountry> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
