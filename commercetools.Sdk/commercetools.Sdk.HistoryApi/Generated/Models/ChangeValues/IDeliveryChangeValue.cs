using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.DeliveryChangeValue))]
    public partial interface IDeliveryChangeValue
    {
        List<IDeliveryItem> Items { get; set; }

        IAddress Address { get; set; }

        List<IParcel> Parcels { get; set; }
    }
}
