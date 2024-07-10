using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
