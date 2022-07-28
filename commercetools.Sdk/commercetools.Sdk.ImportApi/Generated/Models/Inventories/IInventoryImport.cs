using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Inventories.InventoryImport))]
    public partial interface IInventoryImport : IImportResource
    {
        string Sku { get; set; }

        long QuantityOnStock { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        IChannelKeyReference SupplyChannel { get; set; }

        ICustom Custom { get; set; }

    }
}
