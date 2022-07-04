using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;


namespace commercetools.Sdk.ImportApi.Models.Inventories
{
    public partial class InventoryImport : IInventoryImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public long QuantityOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public DateTime? ExpectedDelivery { get; set; }

        public IChannelKeyReference SupplyChannel { get; set; }

        public ICustom Custom { get; set; }
    }
}
