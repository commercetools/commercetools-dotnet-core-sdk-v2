using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction))]
    public partial interface IOrderAddDeliveryAction : IOrderUpdateAction
    {
        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        string ShippingKey { get; set; }

        IBaseAddress Address { get; set; }

        IList<IParcelDraft> Parcels { get; set; }
        IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
