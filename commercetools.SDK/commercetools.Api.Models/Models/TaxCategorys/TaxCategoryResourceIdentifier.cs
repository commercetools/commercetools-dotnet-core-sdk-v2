using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("tax-category")]
    public class TaxCategoryResourceIdentifier : ResourceIdentifier
    {
    }
}
