using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategorySetKeyAction : ITaxCategorySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public TaxCategorySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
