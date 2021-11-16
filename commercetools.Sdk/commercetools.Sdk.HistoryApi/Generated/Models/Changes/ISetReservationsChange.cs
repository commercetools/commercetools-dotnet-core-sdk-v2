using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetReservationsChange))]
    public partial interface ISetReservationsChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        List<IReservation> NextValue { get; set;}
        
        List<IReservation> PreviousValue { get; set;}
    }
}
