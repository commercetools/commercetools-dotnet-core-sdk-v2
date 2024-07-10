using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductImportRequest : IProductImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductImport> Resources { get; set; }
        public IEnumerable<IProductImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product");
        }
    }
}
