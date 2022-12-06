using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.OrderField))]
    public partial interface IOrderField
    {
        IReturnInfo AddReturnInfo { get; set; }

        IDeliveryParcel AddParcelToDelivery { get; set; }

        IList<IDeliveryDraft> AddDeliveries { get; set; }
        IEnumerable<IDeliveryDraft> AddDeliveriesEnumerable { set => AddDeliveries = value.ToList(); }


        IRemoveDeliveryDraft RemoveDelivery { get; set; }

        IRemoveParcelFromDeliveryDraft RemoveParcelFromDelivery { get; set; }

        IDeliveryAddressDraft SetDeliveryAddress { get; set; }

        IParcelMeasurementDraft SetParcelMeasurements { get; set; }

        IParcelTrackingData SetParcelTrackingData { get; set; }

        IList<IParcelItems> SetParcelItems { get; set; }
        IEnumerable<IParcelItems> SetParcelItemsEnumerable { set => SetParcelItems = value.ToList(); }


    }
}
