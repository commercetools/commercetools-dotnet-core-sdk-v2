using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("tax-category")]
    public partial class TaxCategoryResourceIdentifier : ResourceIdentifier
    {
        public TaxCategoryResourceIdentifier()
        { 
           this.TypeId = "tax-category";
        }
    }
}
