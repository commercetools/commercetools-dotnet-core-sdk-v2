using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeDraft : IProductTypeDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IAttributeDefinitionDraft> Attributes { get; set; }
        public IEnumerable<IAttributeDefinitionDraft> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
