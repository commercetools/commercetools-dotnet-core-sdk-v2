using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddDeliveryAction))]
    public partial interface IStagedOrderAddDeliveryAction : IStagedOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set; }

        IBaseAddress Address { get; set; }

        List<IParcelDraft> Parcels { get; set; }

        ICustomFields Custom { get; set; }
    }
}
