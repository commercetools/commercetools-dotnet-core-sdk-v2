using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdate))]
    public partial interface IStoreUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IStoreUpdate, IStoreUpdateAction>
    {
        new long Version { get; set; }
        new IList<IStoreUpdateAction> Actions { get; set; }
        IEnumerable<IStoreUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
