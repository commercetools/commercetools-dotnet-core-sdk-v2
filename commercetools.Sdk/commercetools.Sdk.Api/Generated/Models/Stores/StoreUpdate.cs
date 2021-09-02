using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreUpdate : IStoreUpdate
    {
        public long Version { get; set; }

        public List<IStoreUpdateAction> Actions { get; set; }
    }
}
