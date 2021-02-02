using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.Common
{
    public partial class ProductTypeReference : IProductTypeReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        public ProductTypeReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("product-type");
        }
    }
}
