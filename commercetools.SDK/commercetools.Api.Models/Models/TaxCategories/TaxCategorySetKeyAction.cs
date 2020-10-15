using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DiscriminatorValue("setKey")]
    public partial class TaxCategorySetKeyAction : TaxCategoryUpdateAction
    {
        public string Key { get; set;}
        public TaxCategorySetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
