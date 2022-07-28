using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.DeliveryChangeValue))]
    public partial interface IDeliveryChangeValue
    {
        List<IDeliveryItem> Items { get; set; }

        IAddress Address { get; set; }

        List<IParcel> Parcels { get; set; }

    }
}
