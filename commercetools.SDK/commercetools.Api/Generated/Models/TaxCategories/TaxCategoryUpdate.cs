using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<TaxCategoryUpdateAction> Actions { get; set;}
    }
}
