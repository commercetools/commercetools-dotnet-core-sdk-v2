using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("changeName")]
    public class TaxCategoryChangeNameAction : TaxCategoryUpdateAction
    {
        public string Name { get; set;}
    }
}
