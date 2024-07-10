using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerEmailTokenReference : ICustomerEmailTokenReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerEmailTokenReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-email-token");
        }
    }
}
