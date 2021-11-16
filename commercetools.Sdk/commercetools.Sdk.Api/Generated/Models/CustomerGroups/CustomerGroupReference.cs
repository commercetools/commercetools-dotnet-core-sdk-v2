using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupReference : ICustomerGroupReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public ICustomerGroup Obj { get; set;}
        public CustomerGroupReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("customer-group");
        }
    }
}
