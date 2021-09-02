using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    public partial class ProductReference : IProductReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ProductReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product");
        }
    }
}
