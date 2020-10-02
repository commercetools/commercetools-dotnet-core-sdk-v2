using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("changeName")]
    public partial class TaxCategoryChangeNameAction : TaxCategoryUpdateAction
    {
        public string Name { get; set;}
        public TaxCategoryChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
