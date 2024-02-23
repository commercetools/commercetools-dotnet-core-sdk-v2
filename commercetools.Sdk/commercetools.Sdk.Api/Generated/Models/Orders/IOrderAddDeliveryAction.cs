using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction))]
    public partial interface IOrderAddDeliveryAction : IOrderUpdateAction
    {
        string DeliveryKey { get; set; }

        string ShippingKey { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IBaseAddress Address { get; set; }

        IList<IParcelDraft> Parcels { get; set; }
        IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
