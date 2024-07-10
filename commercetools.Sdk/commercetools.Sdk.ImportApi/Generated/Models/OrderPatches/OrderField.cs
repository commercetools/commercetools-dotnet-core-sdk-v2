using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class OrderField : IOrderField
    {
        public IReturnInfo AddReturnInfo { get; set; }

        public IDeliveryParcel AddParcelToDelivery { get; set; }

        public IList<IDeliveryDraft> AddDeliveries { get; set; }
        public IEnumerable<IDeliveryDraft> AddDeliveriesEnumerable { set => AddDeliveries = value.ToList(); }


        public IRemoveDeliveryDraft RemoveDelivery { get; set; }

        public IRemoveParcelFromDeliveryDraft RemoveParcelFromDelivery { get; set; }

        public IDeliveryAddressDraft SetDeliveryAddress { get; set; }

        public IParcelMeasurementDraft SetParcelMeasurements { get; set; }

        public IParcelTrackingData SetParcelTrackingData { get; set; }

        public IList<IParcelItems> SetParcelItems { get; set; }
        public IEnumerable<IParcelItems> SetParcelItemsEnumerable { set => SetParcelItems = value.ToList(); }

    }
}
