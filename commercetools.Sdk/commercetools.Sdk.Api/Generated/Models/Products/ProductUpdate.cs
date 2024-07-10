using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductUpdate : IProductUpdate
    {
        public long Version { get; set; }

        public IList<IProductUpdateAction> Actions { get; set; }
        public IEnumerable<IProductUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
