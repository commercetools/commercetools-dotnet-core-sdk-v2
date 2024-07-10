using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    public partial interface IDeliveryItemsUpdatedMessage : IOrderMessage
    {
        string DeliveryId { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IList<IDeliveryItem> OldItems { get; set; }
        IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        string ShippingKey { get; set; }

    }
}
