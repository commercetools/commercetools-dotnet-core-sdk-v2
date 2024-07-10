using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class ProductTypeImport : IProductTypeImport
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<IAttributeDefinition> Attributes { get; set; }
        public IEnumerable<IAttributeDefinition> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
