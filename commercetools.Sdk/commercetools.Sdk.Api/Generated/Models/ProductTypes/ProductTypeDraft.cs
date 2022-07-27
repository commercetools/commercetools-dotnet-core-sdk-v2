using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeDraft : IProductTypeDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<IAttributeDefinitionDraft> Attributes { get; set; }
    }
}
