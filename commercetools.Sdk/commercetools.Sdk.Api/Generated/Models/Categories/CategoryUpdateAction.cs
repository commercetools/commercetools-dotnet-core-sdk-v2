using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryUpdateAction : ICategoryUpdateAction
    {
        public string Action { get; set;}
    }
}
