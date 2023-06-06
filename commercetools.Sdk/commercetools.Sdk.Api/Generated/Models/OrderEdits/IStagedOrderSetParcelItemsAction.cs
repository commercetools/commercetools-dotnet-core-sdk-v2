using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction))]
    public partial interface IStagedOrderSetParcelItemsAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        string ParcelKey { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


    }
}
