using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
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
