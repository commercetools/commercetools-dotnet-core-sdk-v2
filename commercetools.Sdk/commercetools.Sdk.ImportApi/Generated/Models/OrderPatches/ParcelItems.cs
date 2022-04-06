using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    public partial class ParcelItems : IParcelItems
    {
        public string ParcelId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
    }
}
