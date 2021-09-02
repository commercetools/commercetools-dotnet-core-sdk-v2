using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Inventories.InventoryImport))]
    public partial interface IInventoryImport : IImportResource
    {
        string Sku { get; set; }

        double QuantityOnStock { get; set; }

        double? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        IChannelKeyReference SupplyChannel { get; set; }

        ICustom Custom { get; set; }
    }
}
