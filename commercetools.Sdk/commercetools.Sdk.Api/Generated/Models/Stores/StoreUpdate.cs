using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreUpdate : IStoreUpdate
    {
        public long Version { get; set; }

        public IList<IStoreUpdateAction> Actions { get; set; }
        public IEnumerable<IStoreUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
