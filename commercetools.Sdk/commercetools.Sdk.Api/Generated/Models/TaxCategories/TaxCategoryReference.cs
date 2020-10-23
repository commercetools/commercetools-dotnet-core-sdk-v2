using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class TaxCategoryReference : ITaxCategoryReference
    {
        public string TypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public ITaxCategory Obj { get; set;}
        public TaxCategoryReference()
        { 
           this.TypeId = "tax-category";
        }
    }
}
