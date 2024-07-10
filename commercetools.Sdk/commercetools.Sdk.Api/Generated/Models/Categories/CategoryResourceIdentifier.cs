using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryResourceIdentifier : ICategoryResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CategoryResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("category");
        }
    }
}
