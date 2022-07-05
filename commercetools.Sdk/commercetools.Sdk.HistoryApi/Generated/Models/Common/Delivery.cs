using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Delivery : IDelivery
    {
        public string Id { get; set; }

        public string CreatedAt { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public List<IParcel> Parcels { get; set; }

        public IAddress Address { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
