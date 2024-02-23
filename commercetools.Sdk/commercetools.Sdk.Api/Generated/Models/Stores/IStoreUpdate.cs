using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdate))]
    public partial interface IStoreUpdate
    {
        long Version { get; set; }

        IList<IStoreUpdateAction> Actions { get; set; }
        IEnumerable<IStoreUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
