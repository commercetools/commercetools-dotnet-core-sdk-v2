using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public string Key { get; set; }

        public long Quantity { get; set; }

        public string LineItemId { get; set; }

        public string CustomLineItemId { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
