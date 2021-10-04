using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class ProductKeyReference : IProductKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ProductKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("product");
        }
    }
}
