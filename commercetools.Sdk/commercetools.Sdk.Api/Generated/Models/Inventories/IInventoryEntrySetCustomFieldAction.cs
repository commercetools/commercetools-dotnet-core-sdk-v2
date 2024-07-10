using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction))]
    public partial interface IInventoryEntrySetCustomFieldAction : IInventoryEntryUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
