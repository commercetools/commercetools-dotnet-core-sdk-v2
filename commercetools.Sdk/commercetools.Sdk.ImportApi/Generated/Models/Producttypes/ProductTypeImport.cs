using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class ProductTypeImport : IProductTypeImport
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<IAttributeDefinition> Attributes { get; set; }
    }
}
