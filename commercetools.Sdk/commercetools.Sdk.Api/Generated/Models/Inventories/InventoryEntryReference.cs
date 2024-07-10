using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryReference : IInventoryEntryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IInventoryEntry Obj { get; set; }
        public InventoryEntryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("inventory-entry");
        }
    }
}
