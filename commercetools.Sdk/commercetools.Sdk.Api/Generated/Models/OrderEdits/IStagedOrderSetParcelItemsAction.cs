using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction))]
    public partial interface IStagedOrderSetParcelItemsAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        List<IDeliveryItem> Items { get; set; }

    }
}
