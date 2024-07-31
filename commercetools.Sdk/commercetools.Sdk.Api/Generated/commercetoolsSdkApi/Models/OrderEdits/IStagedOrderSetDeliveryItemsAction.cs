using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction))]
    public partial interface IStagedOrderSetDeliveryItemsAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

        IList<IDeliveryItem> Items { get; set; }

        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

    }
}
