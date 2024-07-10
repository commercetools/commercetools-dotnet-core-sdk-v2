using commercetools.Sdk.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetKeyAction : ICategorySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public CategorySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
