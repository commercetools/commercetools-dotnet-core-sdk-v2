using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [Discriminator(nameof(Action))]
    public abstract partial class TaxCategoryUpdateAction 
    {
        public string Action { get; set;}
    }
}
