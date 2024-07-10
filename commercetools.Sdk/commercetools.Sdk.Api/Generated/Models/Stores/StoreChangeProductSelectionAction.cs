using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreChangeProductSelectionAction : IStoreChangeProductSelectionAction
    {
        public string Action { get; set; }

        public IProductSelectionResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
        public StoreChangeProductSelectionAction()
        {
            this.Action = "changeProductSelectionActive";
        }
    }
}
