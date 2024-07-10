using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategorySetDescriptionAction : ITaxCategorySetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public TaxCategorySetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
