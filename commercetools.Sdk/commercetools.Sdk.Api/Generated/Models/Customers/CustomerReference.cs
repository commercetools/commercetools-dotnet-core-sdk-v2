using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerReference : ICustomerReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public ICustomer Obj { get; set;}
        public CustomerReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("customer");
        }
    }
}
