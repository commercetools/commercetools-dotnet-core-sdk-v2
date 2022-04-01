using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction))]
    public partial interface IStagedOrderAddDeliveryAction : IStagedOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set; }

        IBaseAddress Address { get; set; }

        List<IParcelDraft> Parcels { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
