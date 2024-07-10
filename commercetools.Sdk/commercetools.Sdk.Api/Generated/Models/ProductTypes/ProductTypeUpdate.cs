using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeUpdate : IProductTypeUpdate
    {
        public long Version { get; set; }

        public IList<IProductTypeUpdateAction> Actions { get; set; }
        public IEnumerable<IProductTypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
