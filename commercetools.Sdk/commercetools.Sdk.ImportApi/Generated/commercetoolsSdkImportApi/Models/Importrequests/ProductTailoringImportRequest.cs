using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.ProductTailorings;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductTailoringImportRequest : IProductTailoringImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductTailoringImport> Resources { get; set; }

        public IEnumerable<IProductTailoringImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public ProductTailoringImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-tailoring");
        }
    }
}
