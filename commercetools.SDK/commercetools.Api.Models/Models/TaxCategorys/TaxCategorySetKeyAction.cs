using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
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
