using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodResourceIdentifier : IShippingMethodResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ShippingMethodResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
