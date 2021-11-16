using commercetools.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ParcelItems : IParcelItems
    {
        public string ParcelId { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
    }
}
