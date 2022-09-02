using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction))]
    public partial interface IOrderAddDeliveryAction : IOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set; }

        string ShippingKey { get; set; }

        IBaseAddress Address { get; set; }

        List<IParcelDraft> Parcels { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
