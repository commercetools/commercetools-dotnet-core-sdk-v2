using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    public class TaxCategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<TaxCategoryUpdateAction> Actions { get; set;}
    }
}
