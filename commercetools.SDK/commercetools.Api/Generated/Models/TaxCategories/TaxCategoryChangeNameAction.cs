using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
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
