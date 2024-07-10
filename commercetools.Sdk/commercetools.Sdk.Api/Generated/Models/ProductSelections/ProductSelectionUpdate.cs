using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionUpdate : IProductSelectionUpdate
    {
        public long Version { get; set; }

        public IList<IProductSelectionUpdateAction> Actions { get; set; }
        public IEnumerable<IProductSelectionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
