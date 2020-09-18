using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("tax-category")]
    public class TaxCategoryReference : Reference
    {
        public TaxCategory Obj { get; set;}
    }
}
