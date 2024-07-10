using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryUpdate : ITaxCategoryUpdate
    {
        public long Version { get; set; }

        public IList<ITaxCategoryUpdateAction> Actions { get; set; }
        public IEnumerable<ITaxCategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
