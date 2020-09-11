using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategorySetCustomFieldAction : CategoryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
