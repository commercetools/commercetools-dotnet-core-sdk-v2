using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryChangeNameAction : ICategoryChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public CategoryChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
