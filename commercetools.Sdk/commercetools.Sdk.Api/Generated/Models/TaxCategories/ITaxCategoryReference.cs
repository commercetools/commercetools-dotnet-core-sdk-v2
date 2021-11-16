using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReference))]
    public partial interface ITaxCategoryReference : IReference
    {
        ITaxCategory Obj { get; set;}
    }
}
