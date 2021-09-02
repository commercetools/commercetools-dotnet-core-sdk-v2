using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryUpdate : ICategoryUpdate
    {
        public long Version { get; set; }

        public List<ICategoryUpdateAction> Actions { get; set; }
    }
}
