using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ProductTailoringUpdate : IProductTailoringUpdate
    {
        public long Version { get; set; }

        public IList<IProductTailoringUpdateAction> Actions { get; set; }
        public IEnumerable<IProductTailoringUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
