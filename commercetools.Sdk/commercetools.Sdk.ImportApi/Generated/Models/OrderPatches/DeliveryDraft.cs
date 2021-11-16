using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class DeliveryDraft : IDeliveryDraft
    {
        public List<IDeliveryItem> Items { get; set;}
        
        public IAddress Address { get; set;}
        
        public List<IDeliveryParcelDraft> Parcels { get; set;}
    }
}
