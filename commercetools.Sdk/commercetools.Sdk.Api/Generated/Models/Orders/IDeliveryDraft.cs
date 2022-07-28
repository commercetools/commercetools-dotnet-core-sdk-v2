using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.DeliveryDraft))]
    public partial interface IDeliveryDraft
    {
        List<IDeliveryItem> Items { get; set; }

        List<IParcelDraft> Parcels { get; set; }

        IAddressDraft Address { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
