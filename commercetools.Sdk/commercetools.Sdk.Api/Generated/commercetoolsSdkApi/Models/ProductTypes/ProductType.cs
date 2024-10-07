using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductType : IProductType
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IAttributeDefinition> Attributes { get; set; }

        public IEnumerable<IAttributeDefinition> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
