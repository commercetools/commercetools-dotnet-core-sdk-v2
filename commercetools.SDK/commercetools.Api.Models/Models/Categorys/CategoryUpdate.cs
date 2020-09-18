using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    public class CategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<CategoryUpdateAction> Actions { get; set;}
    }
}
