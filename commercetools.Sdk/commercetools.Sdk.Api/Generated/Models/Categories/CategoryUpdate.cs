using commercetools.Sdk.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryUpdate : ICategoryUpdate
    {
        public long Version { get; set; }

        public IList<ICategoryUpdateAction> Actions { get; set; }
        public IEnumerable<ICategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
