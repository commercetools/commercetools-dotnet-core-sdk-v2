using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryUpdate : ITaxCategoryUpdate
    {
        public long Version { get; set; }

        public List<ITaxCategoryUpdateAction> Actions { get; set; }
    }
}
