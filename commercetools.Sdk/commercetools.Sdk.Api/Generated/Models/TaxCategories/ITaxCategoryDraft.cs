using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryDraft))]
    public partial interface ITaxCategoryDraft 
    {
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<ITaxRateDraft> Rates { get; set;}
        
        string Key { get; set;}
    }
}
