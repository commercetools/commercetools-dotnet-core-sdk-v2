using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Producttypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class ProductTypeImport : IProductTypeImport
    {
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<IAttributeDefinition> Attributes { get; set;}
    }
}
