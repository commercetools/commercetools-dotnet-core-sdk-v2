using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryUpdate))]
    public partial interface ICategoryUpdate 
    {
        long Version { get; set;}
        
        List<ICategoryUpdateAction> Actions { get; set;}
    }
}
