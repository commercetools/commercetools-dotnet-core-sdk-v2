using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetKeyAction : IInventoryEntrySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public InventoryEntrySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
