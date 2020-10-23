using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.TaxCategories
{
    public interface ITaxCategoryDraft 
    {
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<ITaxRateDraft> Rates { get; set;}
        
        string Key { get; set;}
    }
}
