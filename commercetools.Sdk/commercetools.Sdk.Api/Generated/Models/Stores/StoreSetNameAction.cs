using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetNameAction : IStoreSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public StoreSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
