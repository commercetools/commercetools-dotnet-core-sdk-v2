using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductVariantImportRequest : IProductVariantImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductVariantImport> Resources { get; set; }
        public IEnumerable<IProductVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductVariantImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-variant");
        }
    }
}
