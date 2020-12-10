using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodReference : IShippingMethodReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IShippingMethod Obj { get; set;}
        public ShippingMethodReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
