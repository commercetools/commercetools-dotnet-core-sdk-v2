using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    public class TaxCategoryDraft 
    {
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<TaxRateDraft> Rates { get; set;}
        
        public string Key { get; set;}
    }
}
