using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Inventories.InventoryImport))]
    public partial interface IInventoryImport : IImportResource
    {
        new string Key { get; set; }

        string Sku { get; set; }

        long QuantityOnStock { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        IChannelKeyReference SupplyChannel { get; set; }

        ICustom Custom { get; set; }

    }
}
