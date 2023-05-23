using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction))]
    public partial interface IStagedOrderAddDeliveryAction : IStagedOrderUpdateAction
    {
        string DeliveryKey { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IBaseAddress Address { get; set; }

        IList<IParcelDraft> Parcels { get; set; }
        IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
