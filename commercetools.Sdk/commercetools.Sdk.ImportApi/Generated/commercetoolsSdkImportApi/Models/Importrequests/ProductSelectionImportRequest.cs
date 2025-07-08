using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.ProductSelections;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductSelectionImportRequest : IProductSelectionImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductSelectionImport> Resources { get; set; }

        public IEnumerable<IProductSelectionImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public ProductSelectionImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-selection");
        }
    }
}
