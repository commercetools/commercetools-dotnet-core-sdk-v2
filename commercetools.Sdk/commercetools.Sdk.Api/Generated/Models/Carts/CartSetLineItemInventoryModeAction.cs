using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemInventoryModeAction : ICartSetLineItemInventoryModeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IInventoryMode InventoryMode { get; set; }
        public CartSetLineItemInventoryModeAction()
        {
            this.Action = "setLineItemInventoryMode";
        }
    }
}
