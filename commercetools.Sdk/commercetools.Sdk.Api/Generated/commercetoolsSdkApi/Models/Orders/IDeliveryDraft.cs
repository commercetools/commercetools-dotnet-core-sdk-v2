using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.DeliveryDraft))]
    public partial interface IDeliveryDraft
    {
        string Key { get; set; }

        IList<IDeliveryItem> Items { get; set; }

        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        IList<IParcelDraft> Parcels { get; set; }

        IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }

        IAddressDraft Address { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
