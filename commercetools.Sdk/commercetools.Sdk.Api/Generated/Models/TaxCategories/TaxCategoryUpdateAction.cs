using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryUpdateAction : ITaxCategoryUpdateAction
    {
        public string Action { get; set;}
    }
}
