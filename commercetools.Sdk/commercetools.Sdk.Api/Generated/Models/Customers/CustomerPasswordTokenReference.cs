using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerPasswordTokenReference : ICustomerPasswordTokenReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerPasswordTokenReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-password-token");
        }
    }
}
