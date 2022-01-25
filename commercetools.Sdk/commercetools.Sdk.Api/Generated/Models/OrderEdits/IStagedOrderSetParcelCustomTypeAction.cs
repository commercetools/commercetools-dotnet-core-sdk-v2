using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelCustomTypeAction))]
    public partial interface IStagedOrderSetParcelCustomTypeAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        Object Fields { get; set; }
    }
}
