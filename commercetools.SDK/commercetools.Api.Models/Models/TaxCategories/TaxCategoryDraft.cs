using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryDraft 
    {
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<TaxRateDraft> Rates { get; set;}
        
        public string Key { get; set;}
    }
}
