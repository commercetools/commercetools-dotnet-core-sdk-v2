using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DirectDiscountReference : IDirectDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public DirectDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("direct-discount");
        }
    }
}
