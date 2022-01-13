using commercetools.ImportApi.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ParcelItems))]
    public partial interface IParcelItems
    {
        string ParcelId { get; set; }

        List<IDeliveryItem> Items { get; set; }
    }
}
