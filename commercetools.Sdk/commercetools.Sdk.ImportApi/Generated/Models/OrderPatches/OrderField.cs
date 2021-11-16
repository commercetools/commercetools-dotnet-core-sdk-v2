using System.Collections.Generic;


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
