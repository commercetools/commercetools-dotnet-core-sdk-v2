using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("setDescription")]
    public class TaxCategorySetDescriptionAction : TaxCategoryUpdateAction
    {
        public string Description { get; set;}
    }
}
