using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class InventoryEntryQuantitySetMessage : IInventoryEntryQuantitySetMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public long OldQuantityOnStock { get; set; }

        public long NewQuantityOnStock { get; set; }

        public long OldAvailableQuantity { get; set; }

        public long NewAvailableQuantity { get; set; }
        public InventoryEntryQuantitySetMessage()
        {
            this.Type = "InventoryEntryQuantitySet";
        }
    }
}
