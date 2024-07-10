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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange))]
    public partial interface ISetReservationsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IReservation> PreviousValue { get; set; }
        IEnumerable<IReservation> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IReservation> NextValue { get; set; }
        IEnumerable<IReservation> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
