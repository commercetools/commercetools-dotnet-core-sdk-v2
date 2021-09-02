using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxCategoryResourceIdentifier : ITaxCategoryResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public TaxCategoryResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("tax-category");
        }
    }
}
