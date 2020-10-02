using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    public partial class CategoryUpdate 
    {
        public long Version { get; set;}
        
        public List<CategoryUpdateAction> Actions { get; set;}
    }
}
