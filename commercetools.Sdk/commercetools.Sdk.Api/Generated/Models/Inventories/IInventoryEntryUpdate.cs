using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryUpdate))]
    public partial interface IInventoryEntryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IInventoryEntryUpdate, IInventoryEntryUpdateAction>
    {
        new long Version { get; set; }
        new IList<IInventoryEntryUpdateAction> Actions { get; set; }
        IEnumerable<IInventoryEntryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
