using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartRemoveLineItemAction : IMyCartRemoveLineItemAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long? Quantity { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        public IItemShippingDetailsDraft ShippingDetailsToRemove { get; set; }
        public MyCartRemoveLineItemAction()
        {
            this.Action = "removeLineItem";
        }
    }
}
