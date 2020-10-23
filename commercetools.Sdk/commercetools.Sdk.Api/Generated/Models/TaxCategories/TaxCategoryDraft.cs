using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class TaxCategoryDraft : ITaxCategoryDraft
    {
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<ITaxRateDraft> Rates { get; set;}
        
        public string Key { get; set;}
    }
}
