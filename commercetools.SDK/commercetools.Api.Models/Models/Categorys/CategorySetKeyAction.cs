using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setKey")]
    public partial class CategorySetKeyAction : CategoryUpdateAction
    {
        public string Key { get; set;}
        public CategorySetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
