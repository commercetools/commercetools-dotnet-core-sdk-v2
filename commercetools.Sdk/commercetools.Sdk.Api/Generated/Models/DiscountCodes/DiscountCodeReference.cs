using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeReference : IDiscountCodeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IDiscountCode Obj { get; set; }
        public DiscountCodeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-code");
        }
    }
}
