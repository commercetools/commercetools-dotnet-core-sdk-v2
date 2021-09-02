using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategorySetKeyAction : ITaxCategoryUpdateAction
    {
        string Key { get; set; }
    }
}
