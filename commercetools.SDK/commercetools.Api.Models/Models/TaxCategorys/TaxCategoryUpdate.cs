using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    public partial class TaxCategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<TaxCategoryUpdateAction> Actions { get; set;}
    }
}
