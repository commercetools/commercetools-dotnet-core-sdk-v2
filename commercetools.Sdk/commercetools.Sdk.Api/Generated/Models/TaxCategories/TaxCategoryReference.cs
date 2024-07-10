using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryReference : ITaxCategoryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ITaxCategory Obj { get; set; }
        public TaxCategoryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("tax-category");
        }
    }
}
