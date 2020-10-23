using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public  partial class ProductTypeReference : IProductTypeReference
    {
        public string TypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public IProductType Obj { get; set;}
        public ProductTypeReference()
        { 
           this.TypeId = "product-type";
        }
    }
}
