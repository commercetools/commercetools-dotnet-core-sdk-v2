using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupResourceIdentifier : ICustomerGroupResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public CustomerGroupResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("customer-group");
        }
    }
}
