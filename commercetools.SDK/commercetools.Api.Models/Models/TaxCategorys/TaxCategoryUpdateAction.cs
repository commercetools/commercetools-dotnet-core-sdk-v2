using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [Discriminator(nameof(Action))]
    public abstract class TaxCategoryUpdateAction 
    {
        public string Action { get; set;}
    }
}
