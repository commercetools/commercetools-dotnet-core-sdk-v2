using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class OrderField : IOrderField
    {
        public IReturnInfo AddReturnInfo { get; set; }

        public IDeliveryParcel AddParcelToDelivery { get; set; }

        public List<IDeliveryDraft> AddDeliveries { get; set; }

        public IRemoveDeliveryDraft RemoveDelivery { get; set; }

        public IRemoveParcelFromDeliveryDraft RemoveParcelFromDelivery { get; set; }

        public IDeliveryAddressDraft SetDeliveryAddress { get; set; }

        public IParcelMeasurementDraft SetParcelMeasurements { get; set; }

        public IParcelTrackingData SetParcelTrackingData { get; set; }

        public List<IParcelItems> SetParcelItems { get; set; }
    }
}
