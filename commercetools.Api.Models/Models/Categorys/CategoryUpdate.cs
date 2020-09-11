using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<CategoryUpdateAction> Actions { get; set;}
    }
}
