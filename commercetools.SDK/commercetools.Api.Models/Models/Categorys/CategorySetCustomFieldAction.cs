using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setCustomField")]
    public class CategorySetCustomFieldAction : CategoryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
