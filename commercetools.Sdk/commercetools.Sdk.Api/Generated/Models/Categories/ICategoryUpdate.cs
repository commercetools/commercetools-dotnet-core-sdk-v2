using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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
