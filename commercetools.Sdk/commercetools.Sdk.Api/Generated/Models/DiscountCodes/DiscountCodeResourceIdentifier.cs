using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeResourceIdentifier : IDiscountCodeResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public DiscountCodeResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-code");
        }
    }
}
